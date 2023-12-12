namespace CNET.C.NET.Models {

    public class Computer {
        public int ComputerId {get; set;}
        public string Motherboard {get; set;} = "";
        // private string _motherboard;
        // private string Motherboard {get{return _motherboard;} set(_motherboard = value;)}
        public int? CPUCores {get; set;} 
        public bool HasWifi {get; set;}
        public bool HasLTE {get; set;}
        public string? ReleaseDate {get; set;}
        public decimal Price {get; set;}
        public string VideoCard {get; set;} = "";

        //!! Old Way!
        // public Computer() {
        //     if (Motherboard == null) {
        //         Motherboard = "";
        //     }
        //     if (VideoCard == null) {
        //         VideoCard = "";
        //     }
        // }
    }
    
}