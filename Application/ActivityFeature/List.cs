using MediatR;
using Domain;
using Application.Interfaces;

namespace Application.ActivityFeature
{
    public class List
    {
        public class ActivityRequestQuery : IRequest<IReadOnlyList<Activity>>
        {

        }

        public class ActivityRequestHandler : IRequestHandler<ActivityRequestQuery, IReadOnlyList<Activity>>
        {
            private readonly IReposotory<Activity> _listRepo;
            public ActivityRequestHandler(IReposotory<Activity> listRepo)
            {
                _listRepo = listRepo;
            }

            public async Task<IReadOnlyList<Activity>> Handle(ActivityRequestQuery request, CancellationToken cancellationToken)
            {
                return await _listRepo.GetListAsync();
            }
        }
    }
}