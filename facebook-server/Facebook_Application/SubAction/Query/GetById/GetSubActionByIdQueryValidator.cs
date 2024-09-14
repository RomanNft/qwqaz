﻿using Facebook.Domain.Post;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facebook.Application.SubAction.Query.GetById;

public class GetSubActionByIdQueryValidator : AbstractValidator<SubActionEntity>
{
    public GetSubActionByIdQueryValidator()
    {
        RuleFor(r => r.Id)
            .NotEmpty().WithMessage("Id must not be empty");
    }
}
