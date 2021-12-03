using FootballManagerApi.Data;
using FootballManagerApi.ServiceAbstracts;
using System.Threading.Tasks;

namespace FootballManagerApi.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _dbContext;

        public UnitOfWork(ITeamService teamService, IFootballerService footballerService,
            IManagerService managerService, IManagementPositionService managementPositionService,
            ITacticService tacticService, ICoachService coachService,
            IPositionService positionService, INationalTeamService nationalTeamService,
            ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
            this.FootballerService = footballerService;
            this.TeamService = teamService;
            this.TacticService = tacticService;
            this.ManagerService = managerService;
            this.ManagementPositionService = managementPositionService;
            this.CoachService = coachService;
            this.PositionService = positionService;
            this.NationalTeamService = nationalTeamService;
        }

        public ITeamService TeamService { get; set; }
        public IFootballerService FootballerService { get; set; }
        public ICoachService CoachService { get; set; }
        public IManagementPositionService ManagementPositionService { get; set; }
        public IPositionService PositionService { get; set; }
        public ITacticService TacticService { get; set; }
        public INationalTeamService NationalTeamService { get; set; }
        public IManagerService ManagerService { get; set; }
        IFootballerService IUnitOfWork.FootballerService { get; set; }

        public async Task SaveChangesAsync()
        {
            await _dbContext.SaveChangesAsync();
        }
    }
}
