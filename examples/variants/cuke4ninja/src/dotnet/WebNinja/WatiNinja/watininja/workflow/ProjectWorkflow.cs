﻿using System;
using System.Collections.Generic;
using WatiNinja.watininja.technical;

namespace WatiNinja.watininja.workflow
{
    public class ProjectWorkflow
    {

//START:constructor
private readonly CodeTrack _codeTrack;
public ProjectWorkflow(CodeTrack codeTrack)
{
    _codeTrack = codeTrack;
}
//END:constructor

//START:property
public string CurrentProject { set; get; }
//END:property

//START:addissues
public ProjectWorkflow AddIssues(IList<Issue> issues) {
    foreach (var issue in issues) {
        IssueForm issueForm = _codeTrack.GotoNewIssueForm();
        issueForm.ProjectName = CurrentProject;
        issueForm.Title = issue.Title;
        issueForm.Description = issue.Title;
        issueForm.Severity = issue.Severity;
        issueForm.Submit();
    }
    return this;
}
//END:addissues

//START:assignissue
public ProjectWorkflow AssignIssueToUser(string issueTitle, String user) {
    HomePage homePage = _codeTrack.GotoHomePage();
    homePage.ProjectName = CurrentProject;
    IssuePage issuePage = homePage.ShowIssueWithTitle(issueTitle);
    IssueForm issueForm = issuePage.StartEdit();
    issueForm.AssignTo(user);
    issueForm.Submit();
    return this;
}
//END:assignissue

//START:viewassignedissue
public AssignedIssuesReport ViewAssignedIssuesReport()
{
    ReportsPage reportsPage = _codeTrack.GotoReportsPage();
    IssueTable issueTable = reportsPage.ShowIssuesAssignedToLoggedInUser();
    return new AssignedIssuesReport(issueTable.Issues);
}
//END:viewassignedissue
    }

}
