using FluentValidation;

namespace Application.Features.Comments.Commands.Update;

public class UpdateCommentCommandValidator : AbstractValidator<UpdateCommentCommand>
{
    public UpdateCommentCommandValidator()
    {
        RuleFor(c => c.Id).NotEmpty();
        RuleFor(c => c.Commenter).NotEmpty();
        RuleFor(c => c.Content).NotEmpty();
        RuleFor(c => c.BlogPostId).NotEmpty();
        RuleFor(c => c.MemberId).NotEmpty();
    }
}