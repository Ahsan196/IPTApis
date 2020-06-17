//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PointDataAccess
{
    using System;
    using System.Collections.Generic;
    
    public partial class Student
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Student()
        {
            this.PointPayments = new HashSet<PointPayment>();
            this.StudentPoints = new HashSet<StudentPoint>();
            this.AppliedFors = new HashSet<AppliedFor>();
            this.CourseEnrollments = new HashSet<CourseEnrollment>();
            this.CourseEnrollments1 = new HashSet<CourseEnrollment>();
        }
    
        public int StudentID { get; set; }
        public string SName { get; set; }
        public string Email { get; set; }
        public string MobileNumber { get; set; }
        public string RollNumber { get; set; }
        public int CandidateID { get; set; }
        public int BatchID { get; set; }
        public string SPassword { get; set; }
        public Nullable<int> ProgrammeID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PointPayment> PointPayments { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StudentPoint> StudentPoints { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AppliedFor> AppliedFors { get; set; }
        public virtual Batch Batch { get; set; }
        public virtual CandidateStudent CandidateStudent { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CourseEnrollment> CourseEnrollments { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CourseEnrollment> CourseEnrollments1 { get; set; }
        public virtual Programme Programme { get; set; }
    }
}