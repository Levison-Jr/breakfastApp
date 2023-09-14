using BuberBreakfast.Models;

namespace BuberBreakfast.Services.Breakfasts;

public interface IBreakfastService
{
    Breakfast GetBreakfast(Guid id);
    void CreateBreakfast(Breakfast breakfast);
    void UpsertBreakfast(Breakfast breakfast);
    void DeleteBreakfast(Guid id);
}