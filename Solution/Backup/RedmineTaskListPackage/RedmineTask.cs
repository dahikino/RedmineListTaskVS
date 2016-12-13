﻿using System;
using System.Text.RegularExpressions;
using Microsoft.VisualStudio.Shell;
using Redmine;

namespace RedmineTaskListPackage
{
    public class RedmineTask : Task
    {
        public RedmineTask(RedmineIssue issue, string format)
        {
            CanDelete = false;
            Checked = false;

            IsCheckedEditable = false;
            IsPriorityEditable = false;
            IsTextEditable = false;

            ImageIndex = 2;

            Category = TaskCategory.Misc;
            Document = issue.ProjectName;
            
            // Visual Studio shows line numbers incremented by 1
            Line = issue.Id - 1;
            
            Priority = (TaskPriority)Math.Max(3 - issue.PriorityId, 0);
            Text = GetFormattedDescription(issue, format);
        }

        private static string GetFormattedDescription(RedmineIssue issue, string format)
        {
            try
            {
                return String.Format
                    (Regex.Unescape(format),
                     issue.Id,
                     issue.ProjectId,
                     issue.ProjectName,
                     issue.TrackerId,
                     issue.TrackerName,
                     issue.StatusId,
                     issue.StatusName,
                     issue.PriorityId,
                     issue.PriorityName,
                     issue.AuthorId,
                     issue.AuthorName,
                     issue.AssigneeId,
                     issue.AssigneeName,
                     issue.Subject,
                     issue.Description,
                     issue.StartDate,
                     issue.DueDate,
                     issue.DoneRatio,
                     issue.EstimatedHours,
                     issue.CreationTime,
                     issue.LastUpdateTime,
                     issue.ClosingTime);
            }
            catch (FormatException)
            {
                return "Invalid task description format";
            }
        }
    }
}
