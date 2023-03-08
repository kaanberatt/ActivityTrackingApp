﻿namespace ActivityTrackingApp.Business.Constants;

public static class Messages
{
    private static string addMessage = "Your save is successful.";
    private static string deleteMessage = "Your deletion is successful.";
    private static string updateMessage = "Your update process is complete.";
    private static string userAlreadyExists = "This user already exists.";
    private static string userRegistered = "User registered successfully.";
    private static string userNotFound = "Email is not available in the system. Please try again.";
    private static string passwordError = "Your password is incorrect. Please try again.";
    private static string succesfulLogin = "Login to the system is successful.";
    private static string verificationSend = "Please verify your account from the link that sent to your e-mail address.";
    private static string again = "You have done this before.";
    private static string draftMessage = "Save was successful.";
    private static string errorMessage = "An unexpected error occurred";
    private static string recordMessage = "No record";
    private static string noRecordMessage = "No record found";
    private static string modelErrorMessage = "Model is not valid";
    public static string AddMessage { get { return addMessage; } set { addMessage = value; } }
    public static string DeleteMessage { get { return deleteMessage; } set { deleteMessage = value; } }
    public static string UpdateMessage { get { return updateMessage; } set { updateMessage = value; } }
    public static string UserAlreadyExists { get { return userAlreadyExists; } set { userAlreadyExists = value; } }
    public static string UserRegistered { get { return userRegistered; } set { userRegistered = value; } }
    public static string UserNotFound { get { return userNotFound; } set { userNotFound = value; } }
    public static string PasswordError { get { return passwordError; } set { passwordError = value; } }
    public static string SuccesfulLogin { get { return succesfulLogin; } set { succesfulLogin = value; } }
    public static string VerificationSend { get { return verificationSend; } set { verificationSend = value; } }
    public static string Again { get { return again; } set { again = value; } }
    public static string DraftMessage { get { return draftMessage; } set { draftMessage = value; } }
    public static string ErrorMessage { get { return errorMessage; } set { errorMessage = value; } }
    public static string RecordMessage { get { return recordMessage; } set { recordMessage = value; } }
    public static string NoRecordMessage { get { return noRecordMessage; } set { noRecordMessage = value; } }
    public static string ModelErrorMessage { get { return modelErrorMessage; } set { modelErrorMessage = value; } }
}
