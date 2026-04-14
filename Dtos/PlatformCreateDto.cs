namespace PlatformService.Dtos
{
    //these are the data we will take from user
    public class PlatformCreateDto
    {
     
       //we dont want them to write id


        [Required] 
        public string Name { get; set; } =string.Empty;
        
        [Required]
        public string? Publisher { get; set; }

        [Required]
        public string? Cost { get; set; }
    }



    


    
}