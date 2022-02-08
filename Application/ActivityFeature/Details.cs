using Application.Interfaces;
using Domain;
using MediatR;
namespace Application.ActivityFeature
{
    public class Details
    {
        public class Query : IRequest<Activity>
        {
            public int Id { get; set; }
        }

        public class Handler : IRequestHandler<Query, Activity>
        {
            private readonly IReposotory<Activity> _detailsRepo;
            public Handler(IReposotory<Activity> detailsRepo)
            {
                _detailsRepo = detailsRepo;
            }

            public async Task<Activity> Handle(Query request, CancellationToken cancellationToken)
            {
                return await _detailsRepo.GetByIdAsync(request.Id);
            }
        }
    }
}