using System.IO.MemoryMappedFiles;

namespace NetFrameworkCompat;

public partial class MemoryMappedFile
{
    public static System.IO.MemoryMappedFiles.MemoryMappedFile CreateFromFile(
        FileStream fs, string mapName, long capacity, MemoryMappedFileAccess access,
        object? overridenSecurity, HandleInheritability inheritability, bool leaveOpen
    ) => System.IO.MemoryMappedFiles.MemoryMappedFile.CreateFromFile(fs, mapName, capacity, access, inheritability,
        leaveOpen);

    public static System.IO.MemoryMappedFiles.MemoryMappedFile CreateNew(string? name, uint length,
        MemoryMappedFileAccess readWrite, MemoryMappedFileOptions none, object? unusedOverride,
        HandleInheritability handleInheritability)
        => System.IO.MemoryMappedFiles.MemoryMappedFile.CreateNew(name, length, readWrite, none, handleInheritability);
}