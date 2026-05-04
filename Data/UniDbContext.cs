using Microsoft.EntityFrameworkCore;
using UniversityManagmentSystem.Models;

namespace UniversityManagmentSystem.Data
{
    public class UniDbContext : DbContext
    {
        public UniDbContext(DbContextOptions<UniDbContext> options) : base(options)
        {
        }

        public DbSet<University> University { get; set; } //
        public DbSet<Building> building { get; set; } //
        public DbSet<Block> Blocks { get; set; } //
        public DbSet<Campus> Campuses { get; set; } //
        public DbSet<CourseScheme> courseSchemes { get; set; } //
        public DbSet<DegreeLevel> DegreeLevels { get; set; } //
        public DbSet<DegreeProgram> DegreePrograms { get; set; } //
        public DbSet<Department> Departments { get; set; } //
        public DbSet<Designation> Designations { get; set; } //
        public DbSet<Institute> Institutes { get; set; } //
        public DbSet<ProgramSession> ProgramSessions { get; set; } //
        public DbSet<Faculty> Faculties{ get; set; } //
        public DbSet<FacultyCampus> FacultyCampuses{ get; set; } //
        public DbSet<Semester> Semesters{ get; set; } //
        public DbSet<StructureDesignation> StructureDesignations { get; set; } //
        public DbSet<StructureType>  StructureTyes{ get; set; } //
        public DbSet<StructureUnit>  StructureUnits{ get; set; } //
        public DbSet<Subject> Subjects { get; set; } //
        public DbSet<SubjectType>  SubjectTypes{ get; set; } //
        public DbSet<RoomFeature> RoomFeature { get; set; } //
        public DbSet<Campus> Campus { get; set; }
        public DbSet<Floor> Floor { get; set; } //
        public DbSet<Room> Room { get; set; }   // 
        public DbSet<RoomType> RoomType { get; set; } //
        public DbSet<RoomFeatureAllocation> RoomFeatureAllocation { get; set; } //
        public DbSet<RoomTypeAllocation> RoomTypeAllocation { get; set; } //

        // OBE 
        public DbSet<ProgramLearningOutcomes> ProgramLearningOutcomes { get; set; } //
        public DbSet<CourseLearningOutcomes> CourseLearningOutcomes { get; set; } //
        public DbSet<ProgramEductionOutcomes> ProgramEductionOutcomes{ get; set; } //
        public DbSet<LearningLevel> LearningLevels { get; set; } //
        public DbSet<PloToClo> PloToClos { get; set; } //
        public DbSet<PeoToPlo> PeoToPlos { get; set; } //
        public DbSet<CloToSubject> CloToSubjects { get; set; } //
        //User
        public DbSet<UserInfo> UserInfos { get; set; } //
        public DbSet<UserType> UserTypes { get; set; } //
        public DbSet<UserRight> UserRights { get; set; } //
        public DbSet<UserTypeAllocation> UserTypeAllocations { get; set; } //
        public DbSet<UserRightAllocation> UserRightAllocations { get; set; } //

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            
        }
    }
    
}
