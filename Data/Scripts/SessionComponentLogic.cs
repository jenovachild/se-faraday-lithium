namespace Faraday.Speed200
{
    using Sandbox.Common;
    using Sandbox.Definitions;
    using VRage.Game.Components;

    [MySessionComponentDescriptor(MyUpdateOrder.NoUpdate)]
    public class SessionComponentLogic : MySessionComponentBase
    {
        public override void LoadData()
        {
            MyDefinitionManager.Static.EnvironmentDefinition.SmallShipMaxSpeed = 200;
            MyDefinitionManager.Static.EnvironmentDefinition.LargeShipMaxSpeed = 200;

            base.LoadData();
        }
    }
}
