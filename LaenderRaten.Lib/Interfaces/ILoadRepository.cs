
using LaenderRaten.Lib.Interfaces;
using LaenderRaten.Lib.Models;
using LaenderRaten.Lib.Services;
using System.Runtime.CompilerServices;

namespace LaenderRaten.Lib.Interfaces;

public interface ILoadRepository
{
    public List<Land> LoadAll();
}
