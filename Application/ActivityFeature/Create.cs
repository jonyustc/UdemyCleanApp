using Application.Core;
using Application.Interfaces;
using AutoMapper;
using Domain;
using FluentValidation;
using MediatR;

namespace Application.ActivityFeature
{
    public class Create
    {
        public class Command : IRequest<Result<Activity>>
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

        public class Handler : IRequestHandler<Command, Result<Activity>>
        {
            private readonly IMapper _mapper;
            private readonly IReposotory<Activity> _createRepo;

            public Handler(IReposotory<Activity> createRepo, IMapper mapper)
            {
                _createRepo = createRepo;
                _mapper = mapper;
            }

            public async Task<Result<Activity>> Handle(Command request, CancellationToken cancellationToken)
            {
                //var validator = new ActivityValidator();
                //var validationResult = await validator.ValidateAsync(request.Activity);

                //if (validationResult.Errors.Count > 0)
                //{
                    
                //    var ValidationErrors = new List<string>();
                //    foreach (var error in validationResult.Errors)
                //    {
                //        ValidationErrors.Add(error.ErrorMessage);
                //    }

                //    return Result<Activity>.ValidationFailed(ValidationErrors);
                //}

                _createRepo.Add(request.Activity);

                await _createRepo.SaveChangesAsync();

                return Result<Activity>.Success(request.Activity);
            }
        }
    }
}