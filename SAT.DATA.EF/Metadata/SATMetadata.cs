using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SAT.DATA.EF/*.Metadata*/
{
    class SATMetadata
    {
        #region Cours
        public class CoursMetadata
        {
            [Required(ErrorMessage = "* Please enter a course name.")]
            [Display(Name = "Course name is required.")]
            [StringLength(50, ErrorMessage = "* Must not exceed 50 characters.")]
            public string CourseName { get; set; }

            [Required(ErrorMessage = "* Please enter a course description.")]
            [Display(Name = "Course Description")]
            public string CourseDescription { get; set; }

            [Required(ErrorMessage = "* Please enter a valid amount of credit hours.")]
            [Display(Name = "Credit Hours")]
            [Range(0, byte.MaxValue, ErrorMessage = "* Credit Hours must be a valid number (0 or larger) *")]
            public byte CreditHours { get; set; }

            [StringLength(250, ErrorMessage = "* Must not exceed 250 characters.")]
            [UIHint("MultilineText")]
            public string Curriculum { get; set; }

            [StringLength(500, ErrorMessage = "* Must not exceed 500 characters.")]
            [UIHint("MultilineText")]
            public string Notes { get; set; }

            [Required(ErrorMessage = "* Please enter if this class is active.")]
            [Display(Name = "Is Active")]
            public bool IsActive { get; set; }

        }
        [MetadataType(typeof(CoursMetadata))]

        public partial class Cours
        {

        }
        #endregion

        #region Enrollment

        public class EnrollmentMetadata
        {
            [Required(ErrorMessage = "* Student ID is Required *")]
            [Display(Name = "Student ID")]
            [Range(0, int.MaxValue, ErrorMessage = "* Student ID must be a valid number (0 or larger) *")]
            public int StudentId { get; set; }

            [Required(ErrorMessage = "* Scheduled Class ID is Required *")]
            [Display(Name = "Scheduled ID")]
            [Range(0, int.MaxValue, ErrorMessage = "* Scheduled ID must be a valid number (0 or larger) *")]
            public int ScheduledClassId { get; set; }

            [Required(ErrorMessage = "* Enrolled Date is Required *")]
            [Display(Name = "Enrolled")]
            [DisplayFormat(DataFormatString = "{0:d}")]
            public System.DateTime EnrollmentDate { get; set; }
        }
        [MetadataType(typeof(EnrollmentMetadata))]

        public partial class Enrollment
        {

        }

        #endregion

        #region Scheduled Class Status

        public class ScheduledClassStatusMetadata
        {
            [Required(ErrorMessage = "* Please enter a scheduled class status.")]
            [Display(Name = "Scheduled class status is required.")]
            [StringLength(50, ErrorMessage = "* Must not exceed 50 characters.")]
            public string SCSName { get; set; }
        }

        [MetadataType(typeof(ScheduledClassStatusMetadata))]

        public partial class ScheduledClassStatus
        {

        }

        #endregion

        #region Scheduled Class
        public class ScheduledClassMetadata
        {
            [Required(ErrorMessage = "* Course ID is Required *")]
            [Display(Name = "Course ID")]
            [Range(0, int.MaxValue, ErrorMessage = "* Scheduled ID must be a valid number (0 or larger) *")]
            public int CourseId { get; set; }

            [Required(ErrorMessage = "* Start Date is Required *")]
            [Display(Name = "Start Date")]
            [DisplayFormat(DataFormatString = "{0:d}")]
            public System.DateTime StartDate { get; set; }

            [Required(ErrorMessage = "* End Date is Required *")]
            [Display(Name = "End Date")]
            [DisplayFormat(DataFormatString = "{0:d}")]
            public System.DateTime EndDate { get; set; }

            [Required(ErrorMessage = "* Please enter an instructor name.")]
            [Display(Name = "Instructor name is required.")]
            [StringLength(40, ErrorMessage = "* Must not exceed 40 characters.")]
            public string InstructorName { get; set; }

            [StringLength(20, ErrorMessage = "* Location must be 20 characters or less *")]
            [DisplayFormat(NullDisplayText = "[Not Given]")]
            public string Location { get; set; }

            [Required(ErrorMessage = "* SSC ID is Required *")]
            [Display(Name = "SCS ID")]
            [Range(0, int.MaxValue, ErrorMessage = "* Scheduled ID must be a valid number (0 or larger) *")]
            public int SCSID { get; set; }
        }
        [MetadataType(typeof(ScheduledClassMetadata))]

        public partial class ScheduledClass
        {

        }
        #endregion

        #region Student
        public class StudentMetadata
        {
            [Required(ErrorMessage = "* Required *")]
            [StringLength(20, ErrorMessage = "* First Name must be 20 characters or less *")]
            [Display(Name = "First Name")]
            public string FirstName { get; set; }

            [Required(ErrorMessage = "* Required *")]
            [StringLength(20, ErrorMessage = "* Last Name must be 20 characters or less *")]
            [Display(Name = "Last Name")]
            public string LastName { get; set; }

            [StringLength(15, ErrorMessage = "* Major must be 15 characters or less *")]
            [Display(Name = "Major")]
            public string Major { get; set; }

            [StringLength(50, ErrorMessage = "* Address must be 50 characters or less *")]
            [DisplayFormat(NullDisplayText = "[Not Given]")]
            public string Address { get; set; }

            [StringLength(25, ErrorMessage = "* City must be 25 characters or less *")]
            [DisplayFormat(NullDisplayText = "[Not Given]")]
            public string City { get; set; }

            [StringLength(2, MinimumLength = 2, ErrorMessage = "* State must be 2 characters *")]
            public string State { get; set; }

            [StringLength(10, MinimumLength = 5, ErrorMessage = "* Zip Code must be between 5 and 10 characters *")]
            public string ZipCode { get; set; }

            [StringLength(13, MinimumLength = 10, ErrorMessage = "* Phone number must be between 10 and 13 characters *")]
            public string Phone { get; set; }

            [Required(ErrorMessage = "* Required *")]
            [StringLength(60,ErrorMessage = "* Email must be 60 characters or less *")]
            public string Email { get; set; }

            //Not needed
            public string PhotoUrl { get; set; }

            [Required(ErrorMessage = "* SS ID is Required *")]
            [Display(Name = "SS ID")]
            [Range(0, int.MaxValue, ErrorMessage = "* Scheduled ID must be a valid number (0 or larger) *")]
            public int SSID { get; set; }

        }

        [MetadataType(typeof(StudentMetadata))]

        public partial class Student
        {

        }
        #endregion

        #region Student Status

        public class StudentStatusMetadata
        {
            [Required(ErrorMessage = "* Please enter a SS name.")]
            [Display(Name = "SSName is required.")]
            [StringLength(30, ErrorMessage = "* Must not exceed 30 characters.")]
            public string SSName { get; set; }

            [Required(ErrorMessage = "* Please enter a description.")]
            [Display(Name = "Description is required.")]
            [StringLength(250, ErrorMessage = "* Must not exceed 250 characters.")]
            [UIHint("MultilineText")]
            public string SSDescription { get; set; }

        }

        [MetadataType(typeof(StudentStatusMetadata))]

        public partial class StudentStatus
        {

        }

        #endregion
    }
}

