using System.ComponentModel.DataAnnotations;

namespace StudentData.Models
{
    public class TestAjax
    {
        public int Id { get; set; }

        public string Name { get; set; }

        [Range(1,100)]
        public int Age { get; set; }

        public bool Status { get; set; }
    }
}
