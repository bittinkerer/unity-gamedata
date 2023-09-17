namespace Packages.Estenis.GameData_
{
    public class GameDataNamedAggregate : GameData
    {
        public GameDataNamedAggregate()
        {
            
        }

        public GameDataNamedAggregate(int instanceId) : base(instanceId) { }
        

        public string EventName { get; set; }
        public string Name { get; set; }
        public GameData Data { get; set; }
    }
}
