using Leopotam.EcsLite;

namespace AleVerDes.LeoEcsLiteZoo
{
    public sealed class DelHereEntitySystem<T> : IEcsRunSystem where T : struct
    {
        public void Run(IEcsSystems systems)
        {
            var world = systems.GetWorld();
            var filter = world.Filter<T>().End();
            foreach (var entity in filter)
            {
                world.DelEntity(entity);
            }
        }
    }
}