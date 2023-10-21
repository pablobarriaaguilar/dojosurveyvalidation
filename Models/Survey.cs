using System; 
using System.ComponentModel.DataAnnotations;

namespace dojosurveymvc.Models 

{

    public class Survey 
    {
        
        [MinLength(2)]
        
        public string Name { get; set; }
        [Required]
         
        public string Location { get; set; }
        [Required]
        
        public string Favorite { get; set; }
        [MinLength(20)]
        
        public string Comment { get; set; }

    
    }
}