using Application.Interfaces;
using AutoMapper;
using Domain;
using MediatR;

namespace Application.ActivityFeature
{
    public class Delete
    {
        public class Command : IRequest
        {
            public int Id { get; set; }
        }

        public class Handler : IRequestHandler<Command>
        {
            private readonly IMapper _mapper;
            private readonly IReposotory<Activity> _deleteRepo;
            public Handler(IReposotory<Activity> deleteRepo, IMapper mapper)
            {
                _deleteRepo = deleteRepo;
                _mapper = mapper;
            }

            public async Task<Unit> Handle(Command request, CancellationToken cancellationToken)
            {
                var activity = await _deleteRepo.GetByIdAsync(request.Id);

                _deleteRepo.DeleteAsync(activity);

                await _deleteRepo.SaveChangesAsync();

                return Unit.Value;
            }
        }
    }
}