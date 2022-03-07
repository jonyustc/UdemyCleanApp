using MediatR;
using Domain;
using Application.Interfaces;
using Application.Core;

namespace Application.ActivityFeature
{
    public class List
    {
        public class ActivityRequestQuery : IRequest<Result<Activity>>
        {

        }

        public class ActivityRequestHandler : IRequestHandler<ActivityRequestQuery, Result<Activity>>
        {
            private readonly IReposotory<Activity> _listRepo;

            public ActivityRequestHandler(IReposotory<Activity> listRepo)
            {
                _listRepo = listRepo;
            }

            public async Task<Result<Activity>> Handle(ActivityRequestQuery request, CancellationToken cancellationToken)
            {
                var activities = await _listRepo.GetListAsync();

                return Result<Activity>.Success(activities);
            }
        }
    }
}