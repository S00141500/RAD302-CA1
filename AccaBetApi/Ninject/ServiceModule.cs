using AccaBetApi.DAL;
using Ninject.Modules;

namespace AccaBetApi
{
    public class ServiceModule : NinjectModule
    {
        public override void Load()
        {
            Bind<ICountriesRepository>().To<CountriesRepository>().InSingletonScope();
            Bind<ILeaguesRepository>().To<LeagueRepository>().InSingletonScope();
            Bind<ITeamsRepository>().To<TeamRepository>().InSingletonScope();
        }
    }
}
