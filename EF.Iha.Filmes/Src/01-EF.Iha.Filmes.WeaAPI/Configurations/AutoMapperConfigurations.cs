namespace _01_EF.Iha.Filmes.WeaAPI.Configurations
{
    public static class AutoMapperConfigurations
    {
        public static void AutoMapperConfig(this WebApplicationBuilder builder)
        {
            builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
        }
    }
}
