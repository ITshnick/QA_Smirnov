using Lab_4.PageObjects;

namespace Lab_4.Factory
{
    public static class Pages
    {
        public static HomePageObjects Home => new HomePageObjects(Base.driver);
        public static PetTypesPageObjects PetTypes => new PetTypesPageObjects(Base.driver);
        public static SpecialtiesPageObjects SpecialtiesPage => new SpecialtiesPageObjects(Base.driver);
    }
}
