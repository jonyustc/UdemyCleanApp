using Application.Interfaces;
using AutoMapper;
using Domain;
using FluentValidation;
using MediatR;

namespace Application.ActivityFeature
{
    public class Create
    {
        public class Command : IRequest
        {
            public Activity Activity { get; set; }
        }

        public class CommandValidator : AbstractValidator<Command>
        {
            public CommandValidator()
            {
                RuleFor(x => x.Activity).SetValidator(new ActivityValidator());
            }
        }

        public class Handler : IRequestHandler<Command>
        {
            private readonly IMapper _mapper;
            private readonly IReposotory<Activity> _createRepo;

            public Handler(IReposotory<Activity> createRepo, IMapper mapper)
            {
                _createRepo = createRepo;
                _mapper = mapper;
            }

            public async Task<Unit> Handle(Command request, CancellationToken cancellationToken)
            {
                //var activity=_mapper.Map<Activity>(request);

                _createRepo.Add(request.Activity);

                await _createRepo.SaveChangesAsync();

                return Unit.Value;
            }
        }
    }
}