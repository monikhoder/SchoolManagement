//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SchoolManagement
{
    using System;
    using System.Collections.Generic;
    
    public partial class ClassroomTeacher
    {
        public int Id { get; set; }
        public int ClassroomId { get; set; }
        public int TeacherId { get; set; }
    
        public virtual Classroom Classroom { get; set; }
        public virtual Teacher Teacher { get; set; }
    }
}
