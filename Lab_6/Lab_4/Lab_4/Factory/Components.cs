using Lab_4.Components;

namespace Lab_4.Factory
{
    public static class Component
    {
        public static NavigationComponent Button => new NavigationComponent(Base.driver);
    }
}
