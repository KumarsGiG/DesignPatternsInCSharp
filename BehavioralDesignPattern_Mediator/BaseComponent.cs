namespace BehavioralDesignPattern_Mediator
{
    public class BaseComponent
    {
        protected IMediator _mediator;

#pragma warning disable CS8625 // Cannot convert null literal to non-nullable reference type.

        public BaseComponent(IMediator mediator = null)
            => this._mediator = mediator;

#pragma warning restore CS8625 // Cannot convert null literal to non-nullable reference type.

        public void SetMediator(IMediator mediator)
            => this._mediator = mediator;
    }
}
