using Leopotam.EcsLite;

namespace AleVerDes.LeoEcsLiteZoo
{
    public static class DelHereEx
    {
        public static IEcsSystems DelHere<T>(this IEcsSystems ecsSystems) where T : struct
        {
            ecsSystems.Add(new DelHereSystem<T>());
            return ecsSystems;
        }
        public static IEcsSystems DelHereEntityWith<T>(this IEcsSystems ecsSystems) where T : struct
        {
            ecsSystems.Add(new DelHereEntitySystem<T>());
            return ecsSystems;
        }
    }
}