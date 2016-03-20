namespace GenericsExercise
{
    public class TheVehicle
    {
        public bool IsNewOil { get; set; }
        public bool AreTiresChanged { get; set; }
        public bool IsFilledUp { get; set; }

        public enum GasType
        {
            Regular,
            Diesel,
            HighPerformance
        }
        
        public GasType TypeOfGas { get; set; }
            
        
    }

}