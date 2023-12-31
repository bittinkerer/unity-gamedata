﻿namespace Packages.Estenis.GameData_
{
    public class GameData
    {
        public int InstanceId { get; protected set; } = int.MinValue;

        public GameData() { }
        public GameData(int instanceId) 
        { 
            InstanceId = instanceId;  
        }
    }

    public class GameData<T> : GameData
    {
        
		protected T Data {get; set;} = default;
		
		public GameData(int instanceId, T data)
        {
            Data = data;
            InstanceId = instanceId;
        }

        public GameData(T data)
        {
            Data = data;
			InstanceId = int.MinValue;
        }

        public GameData(int instanceId) : base(instanceId)
        {

        }

        public GameData()
        {
			
        }
    }
}
