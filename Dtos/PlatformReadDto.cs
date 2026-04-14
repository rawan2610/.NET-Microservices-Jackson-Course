namspace PlatformService.Dtos

{
    //this is the data the user will see
    public class PlatformReadDto
    {
     
        public int Id { get; set; }
        
        public string Name { get; set; } =string.Empty;
        
        
        public string? Publisher { get; set; }

        
        public string? Cost { get; set; }
    }



    
}