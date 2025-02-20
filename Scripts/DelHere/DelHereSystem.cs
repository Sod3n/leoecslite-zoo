using Leopotam.EcsLite;

namespace AleVerDes.LeoEcsLiteZoo
{
    public sealed class DelHereSystem<T> : IEcsRunSystem where T : struct
    {
        public void Run(IEcsSystems systems)
        {
            var world = systems.GetWorld();
            var filter = world.Filter<T>().End();
            var pool = world.GetPool<T>();
            foreach (var entity in filter)
            {
                pool.Del(entity);
            }
        }
    }
}