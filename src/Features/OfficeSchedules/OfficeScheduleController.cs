﻿using DentallApp.Features.OfficeSchedules.UseCases;

namespace DentallApp.Features.OfficeSchedules;

[Route("office-schedule")]
[ApiController]
public class OfficeScheduleController : ControllerBase
{
    /// <summary>
    /// Crea un nuevo horario para el consultorio.
    /// </summary>
    [AuthorizeByRole(RolesName.Admin, RolesName.Superadmin)]
    [HttpPost]
    public async Task<Result<CreatedId>> Create(
        [FromBody]CreateOfficeScheduleRequest request,
        CreateOfficeScheduleUseCase useCase)
        => await useCase.ExecuteAsync(User, request);

    /// <summary>
    /// Actualiza el horario de un consultorio.
    /// </summary>
    [AuthorizeByRole(RolesName.Admin, RolesName.Superadmin)]
    [HttpPut("{scheduleId}")]
    public async Task<Result> Update(
        int scheduleId,
        [FromBody]UpdateOfficeScheduleRequest request,
        UpdateOfficeScheduleUseCase useCase)
        => await useCase.ExecuteAsync(scheduleId, User, request);

    /// <summary>
    /// Obtiene el horario de un consultorio activo o inactivo.
    /// </summary>
    [HttpGet("{officeId}")]
    public async Task<IEnumerable<GetSchedulesByOfficeIdResponse>> GetByOfficeId(
        int officeId,
        GetSchedulesByOfficeIdUseCase useCase)
        => await useCase.ExecuteAsync(officeId);
}
