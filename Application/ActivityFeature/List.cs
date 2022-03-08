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
            public PaginationParams param { get; set; }
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
                var activities = _listRepo.GetQueryAble();

                var nullActivity = await _listRepo.GetListAsync();

                


                return Result<Activity>.CreatePagination(activities,request.param.PageNumber,request.param.PageSize);
            }
        }
    }
}