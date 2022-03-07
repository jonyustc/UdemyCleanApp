using Application.Interfaces;
using AutoMapper;
using Domain;
using FluentValidation;
using MediatR;

namespace Application.ActivityFeature
{
    public class Edit
    {
        public class Command : IRequest
        {
            public Activity Activity { get; set; }
        }


        //public class commandvalidator : abstractvalidator<command>
        //{
        //    public commandvalidator()
        //    {
        //        rulefor(x => x.activity).setvalidator(new activityvalidator());
        //    }
        //}

        public class Handler : IRequestHandler<Command>
        {
            private readonly IMapper _mapper;
            private readonly IReposotory<Activity> _editRepo;
            public Handler(IReposotory<Activity> editRepo, IMapper mapper)
            {
                _editRepo = editRepo;
                _mapper = mapper;
            }

            public async Task<Unit> Handle(Command request, CancellationToken cancellationToken)
            {
                var activity = await _editRepo.GetByIdAsync(request.Activity.Id);

                _mapper.Map(request.Activity, activity);

                await _editRepo.SaveChangesAsync();

                return Unit.Value;
            }
        }
    }
}