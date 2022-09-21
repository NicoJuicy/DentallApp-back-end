﻿namespace DentallApp.Features.Reports.DTOs;

public class ReportPostDentalServiceDto
{
    public string From { get; set; }
    public string To { get; set; }
    public string OfficeName { get; set; }
    public IEnumerable<ReportPostDentalServiceDetailsDto> Services { get; set; }
}
