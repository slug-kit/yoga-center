﻿using YogaCenter.Repository.Models;

namespace YogaCenter.Repository.DAL;

public class ProgramDAO
{
    private static ProgramDAO? instance;
    private readonly static object instanceLock = new();
    public static ProgramDAO Instance
    {
        get
        {
            lock (instanceLock)
            {
                instance ??= new ProgramDAO();
                return instance;
            }
        }
    }

    public IEnumerable<Program> GetAll()
    {
        using var db = new YogaCenterContext();
        return db.Programs.ToList();
    }

    public Program? Get(int id)
    {
        using var db = new YogaCenterContext();
        return db.Programs.FirstOrDefault(p => p.Id == id);
    }

    public void Add(Program program)
    {
        using var db = new YogaCenterContext();
        db.Programs.Add(program);
        db.SaveChanges();
    }

    public void Update(Program program)
    {
        var p = Get(program.Id);
        if (p != null)
        {
            using var db = new YogaCenterContext();
            db.Programs.Update(program);
            db.SaveChanges();
        }
    }

    public void Remove(Program program)
    {
        var p = Get(program.Id);
        if (p != null)
        {
            p.Inactive = true;
            Update(p);
        }
    }
}