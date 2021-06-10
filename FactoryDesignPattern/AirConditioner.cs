using System;
using System.Collections.Generic;

public class AirConditioner
{
    private readonly Dictionary<Actions, AirConditionerFactory> _factories;

    public AirConditioner()
    {
        _factories = new Dictionary<Actions, AirConditionerFactory>
        {
            { Actions.Cooling, new CoolingFactory() },
            { Actions.Warming, new WarmingFactory() }
        };
    }




    public static AirConditioner InitializeFactories() => new AirConditioner();

    public IAirConditioner ExecuteCreation(Actions action, double temperature) => _factories[action].Create(temperature);
}