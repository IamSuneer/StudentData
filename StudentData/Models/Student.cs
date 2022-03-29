using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentData.Models
{
    public enum Level
    {
        School = 1,
        [Display(Name ="+2")]
        HighSchool = 2,
        Bachelor = 3,
        Master = 4,
        PhD = 5,
    }

    public enum Gender
    {
        Unknown, Male, Female
    }

    public enum Hobby
    {
        Singing, Dancing, Sports, Reading, Writing, Sleeping
    }

    public class Student
    {
        public int StudentId { get; set; }


        [Required]
        [StringLength(20,MinimumLength =3)]
        [Display(Name ="First Name")]
        public string FirstName { get; set; }


        [Required]
        [StringLength(20, MinimumLength =4)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }


        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode =true )]
        [Display(Name = "Date of Birth")]
        public DateTime DateOfBirth { get; set; }


        [Range(1,50)]
        public int Age
        {
            get
            {
                return (int) (DateTime.Now.Year - DateOfBirth.Year);
            }
        }

        public Level Level { get; set; }


        public Gender Gender { get; set; }


        [Display(Name ="Image")]
        public string? ProfilePicture { get; set; }


        [NotMapped]
        [Display(Name = "Upload File")]
        public IFormFile UploadFile { get; set; }


        public Hobby? Hobby { get; set; }


        [Display(Name = "Name")]
        public string FullName
        {
            get
            {
                return FirstName+ " " +LastName;
            }
        }


        public bool IsActive { get; set; }


        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Created Date")]
        public DateTime CreatedDate { get; set; } = DateTime.Now;


        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Updated Date")]
        public DateTime UpdatedDate { get; set; } = DateTime.Now;

    }
}
    