﻿using System;
using System.Collections.Generic;
using Dapper;
using VersionManager.DataAccess.Repositories;
using VersionManager.Entities;
using VersionManager.Model;
using VersionManager.Utilities;
using static VersionManager.Utilities.DataStructure;

namespace VersionManager.DataControl.Controllers
{
    public class VersionsController : IController<Versions, VersionDto>
    {
        ICommandText commandText;
        private Repository<Versions> repository;
        public VersionsController()
        {
            commandText = new VersionsCommandText();
            repository = new Repository<Versions>(/*configuration,*/ commandText);
        }
        public Versions Add(VersionDto versions)
        {
            return repository.Add(GetAddParameter(versions));
        }

        public void Delete(int id)
        {
            repository.Delete(id);
        }

        public void Dispose()
        {
            commandText = null;
            repository = null;
        }

        public List<VersionDto> GetAll()
        {
            return repository.Get().ToXList<Versions, VersionDto>();
        }

        public VersionDto GetById(int id)
        {
            return repository.GetById(id).ToDto<Versions, VersionDto>();
        }

        public List<VersionDto> GetForUpdate(string versionCode)
        {
            return repository.GetForUpate(versionCode).ToXList<Versions, VersionDto>();
        }

        public Versions Save(DataStructure.FormAction formAction, VersionDto versions)
        {
            if (formAction == FormAction.Add)
                return Add(versions);
            else
            {
                Update(versions);
                return null;
            }
        }

        public void Update(VersionDto versions)
        {
            repository.Update(GetUpdateParameter(versions));
        }

        public string MaxCode()
        {
            return repository.MaxCode();
        }

        internal DynamicParameters GetAddParameter(VersionDto versions)
        {
            return new DynamicParameters(new
            {
                VersionCode = versions.VersionCode,
                VersionName = versions.VersionName,
                DllPath = versions.DllPath,
                StructureScriptPath = versions.StructureScriptPath,
                AlterScriptPath = versions.AlterScriptPath,
                VersionDescription = versions.VersionDescription
            });
        }

        internal DynamicParameters GetUpdateParameter(VersionDto versions)
        {
            return new DynamicParameters(new
            {
                ID = versions.ID,
                VersionCode = versions.VersionCode,
                VersionName = versions.VersionName,
                DllPath = versions.DllPath,
                StructureScriptPath = versions.StructureScriptPath,
                AlterScriptPath = versions.AlterScriptPath,
                VersionDescription = versions.VersionDescription
            });
        }
    }
    public class VersionsCommandText : ICommandText
    {
        public string GetById => nameof(Versions) + "_SelectById";
        public string Get => nameof(Versions) + "_Select";
        public string Add => nameof(Versions) + "_Insert";
        public string Update => nameof(Versions) + "_Update";
        public string Delete => nameof(Versions) + "_Delete";
        public string MaxCode => nameof(Versions) + "_MaxCode";
        public string GetForUpdate => nameof(Versions) + "_SelectForUpdate";
    }
}
