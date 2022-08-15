﻿using Task = KanBanApp.Models.Task;

namespace KanBanApp.Store.Actions.Delete;

public class DeleteTaskAction
{
    public DeleteTaskAction(Task? task)
    {
        Task = task;
    }

    public Task? Task { get; set; }
}