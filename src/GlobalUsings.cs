global using DentallApp.Features.Chatbot;
global using DentallApp.Features.Chatbot.Dialogs;
global using DentallApp.Features.Chatbot.Factories;
global using DentallApp.Features.Chatbot.Helpers;
global using DentallApp.Features.Chatbot.Models;
global using DentallApp.Features.Chatbot.Handlers;
global using DentallApp.Features.Chatbot.Extensions;
global using DentallApp.Features.GeneralTreatments;
global using DentallApp.Features.GeneralTreatments.DTOs;
global using DentallApp.Features.SpecificTreatments;
global using DentallApp.Features.SpecificTreatments.DTOs;
global using DentallApp.Features.ProformaInvoice;
global using DentallApp.Features.ProformaInvoice.DTOs;
global using DentallApp.Features.PersonalInformation;
global using DentallApp.Features.PersonalInformation.DTOs;
global using DentallApp.Features.PersonalInformation.Genders;
global using DentallApp.Features.PersonalInformation.Genders.DTOs;
global using DentallApp.Features.Users;
global using DentallApp.Features.Users.DTOs;
global using DentallApp.Features.Dependents;
global using DentallApp.Features.Dependents.DTOs;
global using DentallApp.Features.Dependents.Kinships;
global using DentallApp.Features.Dependents.Kinships.DTOs;
global using DentallApp.Features.UserRegistration;
global using DentallApp.Features.Roles;
global using DentallApp.Features.Roles.DTOs;
global using DentallApp.Features.SecurityToken;
global using DentallApp.Features.SecurityToken.DTOs;
global using DentallApp.Features.TokenRefresh;
global using DentallApp.Features.Authentication;
global using DentallApp.Features.Authentication.DTOs;
global using DentallApp.Features.EmailSending;
global using DentallApp.Features.EmailVerification;
global using DentallApp.Features.EmailVerification.DTOs;
global using DentallApp.Features.PasswordReset;
global using DentallApp.Features.PasswordReset.DTOs;
global using DentallApp.Features.Employees;
global using DentallApp.Features.Employees.DTOs;
global using DentallApp.Features.Employees.Roles;
global using DentallApp.Features.Employees.Specialties;
global using DentallApp.Features.Offices;
global using DentallApp.Features.Offices.DTOs;
global using DentallApp.Features.Appointments;
global using DentallApp.Features.Appointments.DTOs;
global using DentallApp.Features.Appointments.AppointmentsStatus;
global using DentallApp.Features.Appointments.AppointmentsStatus.DTOs;
global using DentallApp.Features.Appointments.Notification;
global using DentallApp.Features.AppointmentCancellation;
global using DentallApp.Features.AppointmentCancellation.DTOs;
global using DentallApp.Features.AvailabilityHours;
global using DentallApp.Features.AvailabilityHours.DTOs;
global using DentallApp.Features.EmployeeSchedules;
global using DentallApp.Features.EmployeeSchedules.DTOs;
global using DentallApp.Features.WeekDays;
global using DentallApp.Features.FavoriteDentists;
global using DentallApp.Features.FavoriteDentists.DTOs;
global using DentallApp.Features.OfficeSchedules;
global using DentallApp.Features.OfficeSchedules.DTOs;
global using DentallApp.Features.AppointmentReminders;
global using DentallApp.Features.AppointmentScheduling.DTOs;
global using DentallApp.Features.Reports;
global using DentallApp.Features.Reports.DTOs;
global using DentallApp.Features.Reports.Pdf;
global using DentallApp.Features.PublicHolidays;
global using DentallApp.Features.PublicHolidays.DTOs;
global using DentallApp.Features.PublicHolidays.Offices;

global using DentallApp.Configuration;
global using DentallApp.DataAccess;
global using DentallApp.DataAccess.Repositories;
global using DentallApp.DataAccess.UnitOfWork;
global using DentallApp.DataAccess.DbConnectors;
global using DentallApp.DataAccess.DbTransactions;
global using DentallApp.Entities;
global using DentallApp.Entities.BaseClasses;
global using DentallApp.Entities.Interfaces;
global using DentallApp.Attributes;
global using DentallApp.Helpers;
global using DentallApp.Helpers.HtmlConverterHelpers;
global using DentallApp.Helpers.TemplateEngineHelpers;
global using DentallApp.Helpers.DateTimeHelpers;
global using DentallApp.Helpers.InstantMessaging;
global using DentallApp.Helpers.PasswordHasher;
global using DentallApp.Responses;
global using Response = DentallApp.Responses.Response;
global using DentallApp.Extensions;
global using DentallApp.Constants;
global using static DentallApp.Constants.ResponseMessages;
global using static DentallApp.Constants.MessageTemplates;

global using System.Data;
global using System.Text;
global using System.Text.Encodings.Web;
global using System.Linq.Expressions;
global using System.Reflection;
global using System.Security.Claims;
global using System.Security.Cryptography;
global using System.ComponentModel.DataAnnotations.Schema;
global using System.ComponentModel.DataAnnotations;
global using System.IdentityModel.Tokens.Jwt;

global using Microsoft.Bot.Builder;
global using Microsoft.Bot.Builder.Integration.AspNet.Core;
global using Microsoft.Bot.Builder.Dialogs;
global using Microsoft.Bot.Builder.TraceExtensions;
global using Microsoft.Bot.Schema;
global using Microsoft.Bot.Connector.Authentication;
global using AdaptiveCards;

global using Microsoft.AspNetCore.Mvc;
global using Microsoft.AspNetCore.Authentication;
global using Microsoft.AspNetCore.Authentication.JwtBearer;
global using Microsoft.AspNetCore.Authorization;


global using Microsoft.EntityFrameworkCore;
global using Microsoft.EntityFrameworkCore.Diagnostics;
global using Microsoft.EntityFrameworkCore.Metadata.Builders;
global using Microsoft.EntityFrameworkCore.Query.SqlExpressions;
global using Microsoft.EntityFrameworkCore.Storage;
global using Microsoft.IdentityModel.Tokens;
global using Microsoft.IdentityModel.Logging;
global using Microsoft.OpenApi.Models;
global using Microsoft.Extensions.Options;

global using Newtonsoft.Json.Linq;
global using Newtonsoft.Json;

global using DotEnv.Core;
global using Dapper;

global using SendGrid;
global using SendGrid.Helpers.Mail;
global using SendGrid.Extensions.DependencyInjection;

global using DelegateDecompiler;
global using FileTypeChecker;
global using FileTypeChecker.Extensions;
global using iText.Html2pdf;
global using Scriban;
global using Quartz;
