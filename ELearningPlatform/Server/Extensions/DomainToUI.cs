using ELearningPlatform.Server.Data.Models;

namespace ELearningPlatform.Server.Extensions;

public static class DomainToUI
{
    public static Shared.CurseLevel ToUI(this CurseLevel item) => new(item.Id, item.Name);
    public static Shared.Language ToUI(this Language item) => new(item.Id, item.Name);
    public static Shared.Course ToUI(this Course item) => new(item.Id, 0, 0, item.Language.ToUI(), item.Level.ToUI(), item.Tutor.ToUI(), new List<Shared.CourseStudent>());
    public static Shared.Tutor ToUI(this Tutor item) => new(item.Id, item.User.ToUI());
    public static Shared.User ToUI(this User item) => new(item.Id, item.Name, item.Surname, item.BirthDate, item.Pesel);

    public static IEnumerable<Shared.CurseLevel> ToUI(this IEnumerable<CurseLevel> items) => items.Select(x => x.ToUI()) ?? Enumerable.Empty<Shared.CurseLevel>();
    public static IEnumerable<Shared.Language> ToUI(this IEnumerable<Language> items) => items.Select(x => x.ToUI()) ?? Enumerable.Empty<Shared.Language>();
    public static IEnumerable<Shared.Course> ToUI(this IEnumerable<Course> items) => items.Select(x => x.ToUI()) ?? Enumerable.Empty<Shared.Course>();
    public static IEnumerable<Shared.Tutor> ToUI(this IEnumerable<Tutor> items) => items.Select(x => x.ToUI()) ?? Enumerable.Empty<Shared.Tutor>();
    public static IEnumerable<Shared.User> ToUI(this IEnumerable<User> items) => items.Select(x => x.ToUI()) ?? Enumerable.Empty<Shared.User>();
}
