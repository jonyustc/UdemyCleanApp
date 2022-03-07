using Application.Core;
using Application.Interfaces;
using Domain;
using MediatR;
namespace Application.ActivityFeature
{
    public class Details
    {
        public class Query : IRequest<Result<Activity>>
        {
            public int Id { get; set; }
        }

        public class Handler : IRequestHandler<Query, Result<Activity>>
        {
            private readonly IReposotory<Activity> _detailsRepo;
            public Handler(IReposotory<Activity> detailsRepo)
            {
                _detailsRepo = detailsRepo;
            }

            public async Task<Result<Activity>> Handle(Query request, CancellationToken cancellationToken)
            {
                var data = await _detailsRepo.GetByIdAsync(request.Id);

                
                data.Id.ToString();
                //if(data == null)
                //    return Result<Activity>.Failed(new List<string> { "Activity not found" });


                return Result<Activity>.Success(data);
                
            }
        }
    }
}