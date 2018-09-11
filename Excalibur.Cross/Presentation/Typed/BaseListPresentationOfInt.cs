using Excalibur.Cross.Observable.Typed;
using Excalibur.Cross.Storage.Typed;

// ReSharper disable once CheckNamespace
namespace Excalibur.Cross.Presentation.Typed
{
    /// <inheritdoc cref="BaseListPresentationOfInt{TDomain,TObservable,TObservable}"/>
    public class BaseListPresentationOfInt<TDomain, TObservable> : BaseListPresentationOfInt<TDomain, TObservable, TObservable>, IListPresentationOfInt<TObservable>
        where TDomain : StorageDomainOfInt
        where TObservable : ObservableBaseOfInt, new()
    {
    }

    /// <inheritdoc cref="BaseListPresentation{TId,TDomain,TObservable,TSelectedObservable}"/>
    public class BaseListPresentationOfInt<TDomain, TObservable, TSelectedObservable> : BaseListPresentation<int, TDomain, TObservable, TSelectedObservable>, IListPresentationOfInt<TObservable, TSelectedObservable>
        where TDomain : StorageDomainOfInt
        where TObservable : ObservableBaseOfInt, new()
        where TSelectedObservable : ObservableBaseOfInt, new()
    {
    }
}