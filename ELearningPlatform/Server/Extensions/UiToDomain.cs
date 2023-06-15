using ELearningPlatform.Server.Data.Models;

namespace ELearningPlatform.Server.Extensions;

public static class UiToDomain
{
    public static CurseLevel ToDomain(this Shared.CurseLevel item) => new(item.Name);
    public static Language ToDomain(this Shared.Language item) => new(item.Name);
    public static Course ToDomain(this Shared.Course item) => new(1, item.Language.Id, item.Level.Id, item.Price);
    public static Tutor ToDomain(this Shared.Tutor item) => new(item.User.Id);
    public static User ToDomain(this Shared.User item) => new(item.Name, item.Surname, item.BirthDate, item.Pesel);

    public static IEnumerable<CurseLevel> ToDomain(this IEnumerable<Shared.CurseLevel> items) => items.Select(x => x.ToDomain()) ?? Enumerable.Empty<CurseLevel>();
    public static IEnumerable<Language> ToDomain(this IEnumerable<Shared.Language> items) => items.Select(x => x.ToDomain()) ?? Enumerable.Empty<Language>();
    public static IEnumerable<Course> ToDomain(this IEnumerable<Shared.Course> items) => items.Select(x => x.ToDomain()) ?? Enumerable.Empty<Course>();
    public static IEnumerable<Tutor> ToDomain(this IEnumerable<Shared.Tutor> items) => items.Select(x => x.ToDomain()) ?? Enumerable.Empty<Tutor>();
    public static IEnumerable<User> ToDomain(this IEnumerable<Shared.User> items) => items.Select(x => x.ToDomain()) ?? Enumerable.Empty<User>();
}