using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection.Extensions;
using UniversityManagmentSystem.Data;
using UniversityManagmentSystem.Interfaces;
using UniversityManagmentSystem.Repositories;
using UniversityManagmentSystem.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddDbContext<UniDbContext>(db =>
    db.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddControllers();
builder.Services.AddScoped<IBlockRepository, BlockRepository>();
builder.Services.AddScoped<IBuildingRepository, BuildingRepository>();
builder.Services.AddScoped<ICampusRepository, CampusRepository>();
builder.Services.AddScoped<ICLORepository, CLORepository>();
builder.Services.AddScoped<ICloToSubjectRepository, CloToSubjectRepository>();
builder.Services.AddScoped<ICourseSchemeRepository, CourseSchemeRepository>();
builder.Services.AddScoped<IDegreeLevelRepository, DegreeLevelRepository>();
builder.Services.AddScoped<IDegreeProgramRepository, DegreeProgramRepository>();
builder.Services.AddScoped<IDepartmentRepository, DepartmentRepository>();
builder.Services.AddScoped<IDesignationRepository, DesignationRepository>();
builder.Services.AddScoped<IFacultyCampusRepository, FacultyCampusRepository>();
builder.Services.AddScoped<IFacultyRepository, FacultyRepository>();
builder.Services.AddScoped<IFloorRepository, FloorRepository>();
builder.Services.AddScoped<IInstituteRepository, InstituteRepository>();
builder.Services.AddScoped<ILearningLevelRepository, LearningLevelRepository>();
builder.Services.AddScoped<IPEORepository, PEORepository>();
builder.Services.AddScoped<IPeoToPloRepository, PeoToPloRepository>();
builder.Services.AddScoped<IPLORepository, PLORepository>();
builder.Services.AddScoped<IPloToCloRepository, PloToCloRepository>();
builder.Services.AddScoped<IProgramSessionRepository, ProgramSessionRepository>();
builder.Services.AddScoped<IRoomFeatureAllocationRepository, RoomFeatureAllocationRepository>();
builder.Services.AddScoped<IRoomFeatureRepository, RoomFeatureRepository>();
builder.Services.AddScoped<IRoomRepository, RoomRepository>();
builder.Services.AddScoped<IRoomTypeAllocationRepository, RoomTypeAllocationRepository>();
builder.Services.AddScoped<IRoomTypeRepository, RoomTypeRepository>();
builder.Services.AddScoped<ISemesterRepository, SemesterRepository>();
builder.Services.AddScoped<IStructureDesignationRepository, StructureDesignationRepository>();
builder.Services.AddScoped<IStructureTypeRepository, StructureTypeRepository>();
builder.Services.AddScoped<IStructureUnitRepository, StructureUnitRepository>();
builder.Services.AddScoped<ISubjectRepository, SubjectRepository>();
builder.Services.AddScoped<ISubjectTypeRepository, SubjectTypeRepository>();
builder.Services.AddScoped<IUniversityRepository, UniversityRepository>();
builder.Services.AddScoped<IUserInfoRepository, UserInfoRepository>();
builder.Services.AddScoped<IUserRightAllocationRepository, UserRightAllocationRepository>();
builder.Services.AddScoped<IUserRightRepository, UserRightRepository>();
builder.Services.AddScoped<IUserTypeAllocationRepository, UserTypeAllocationRepository>();
builder.Services.AddScoped<IUserTypeRepository, UserTypeRepository>();



builder.Services.AddScoped<BlockServices>();
builder.Services.AddScoped<BuildingServices>();
builder.Services.AddScoped<CampusServices>();
builder.Services.AddScoped<CLOServices>();
builder.Services.AddScoped<CloToSubjectServices>();
builder.Services.AddScoped<CourseSchemeServices>();
builder.Services.AddScoped<DegreeLevelService>();
builder.Services.AddScoped<DegreeProgramServices>();
builder.Services.AddScoped<DepartmentServices>();
builder.Services.AddScoped<DesignationService>();
builder.Services.AddScoped<FacultyCampusServices>();
builder.Services.AddScoped<FacultyService>();
builder.Services.AddScoped<FloorServices>();
builder.Services.AddScoped<InstituteServices>();
builder.Services.AddScoped<LearningLevelServices>();
builder.Services.AddScoped<PeoServices>();
builder.Services.AddScoped<PeoToPloServices>();
builder.Services.AddScoped<PloServices>();
builder.Services.AddScoped<PloToCloServices>();
builder.Services.AddScoped<ProgramSessionService>();
builder.Services.AddScoped<RoomFeatureAllocationServices>();
builder.Services.AddScoped<RoomFeatureService>();
builder.Services.AddScoped<RoomServices>();
builder.Services.AddScoped<RoomTypeAllocationServices>();
builder.Services.AddScoped<RoomTypeService>();
builder.Services.AddScoped<SemesterService>();
builder.Services.AddScoped<StructureDesignationServices>();
builder.Services.AddScoped<StructureTypeService>(); 
builder.Services.AddScoped<StructureUnitServices>();
builder.Services.AddScoped<SubjectService>();
builder.Services.AddScoped<SubjectTypeService>();
builder.Services.AddScoped<UniversityServices>();
builder.Services.AddScoped<UserInfoServices>();
builder.Services.AddScoped<UserRightAllocationServices>();
builder.Services.AddScoped<UserRightServices>();
builder.Services.AddScoped<UserTypeAllocationServices>();
builder.Services.AddScoped<UserTypeServices>();




builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowLocalhost3000", policy =>
    {
        policy.WithOrigins("http://localhost:3000", "http://127.0.0.1:3000")
              .AllowAnyHeader()
              .AllowAnyMethod();
    });
});

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();


app.UseCors("AllowLocalhost3000");


if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
