﻿Option Explicit On 
Option Strict On
Imports System.IO

Public Class CWordReport

    Private Const c_ReportTemplatesDir As String = "Reports\Templates\"
    Private Const c_ReportOutputDir As String = "Reports\Output\"

    Protected m_strOutputPath As String = ""
    Protected m_strTemplatesPath As String = ""

    Private m_strTemplateFileNameWithPath As String

    Private m_objWordlApp As Word.Application
    Private m_objWordDocument As Word.Document
    Private m_obj_doc As Word.Document



    Private m_init_successful As Boolean
    Private m_o_missing As Object = System.Reflection.Missing.Value
    Private m_hst_FindAndReplaceCollection As Hashtable
#Region "Public Interface"
    Public Sub New(ByVal i_strTemplateFileWithoutPath As String, ByVal i_strFileOutputPath As String)
        If My.Computer.FileSystem.FileExists(i_strFileOutputPath) Then
            My.Computer.FileSystem.DeleteFile(i_strFileOutputPath)
        End If
        InitPaths()
        m_strTemplateFileNameWithPath = m_strTemplatesPath & i_strTemplateFileWithoutPath
        m_objWordlApp = New Word.Application
        m_hst_FindAndReplaceCollection = New Hashtable
        m_init_successful = False
        m_strOutputPath = i_strFileOutputPath
        InitWord()
    End Sub
    Public Sub Export2Word(ByVal i_b_image As String, Optional ByVal i_b_show As Boolean = True)
        

        m_obj_doc = m_objWordlApp.ActiveDocument
        If i_b_image <> "" Then
            m_obj_doc.InlineShapes.AddPicture(i_b_image, Type.Missing, Type.Missing, Type.Missing)
        End If
        Dim v_str_replace As Object
        For Each v_str_find As Object In Me.m_hst_FindAndReplaceCollection.Keys
            v_str_replace = Me.m_hst_FindAndReplaceCollection.Item(v_str_find).ToString()
            Me.FindAndReplace(v_str_find, v_str_replace)
        Next

        m_objWordDocument.Save()
        If i_b_show Then
            m_objWordlApp.Visible = True
            Unmount()
        End If
        m_objWordlApp.Quit()
    End Sub
    Public Sub AddFindAndReplace(ByVal i_str_find As String, ByVal i_str_replace As String)
        m_hst_FindAndReplaceCollection.Add(i_str_find, i_str_replace)
    End Sub
    Public Function GetOutputFileNameWithPath() As String
        Dim v_strRandomName As String
        Randomize()
        v_strRandomName = m_strOutputPath
        Return v_strRandomName
    End Function
#End Region

#Region "Private Methods"
    Private Sub InitWord()
        Dim v_strFileName As Object
        v_strFileName = GetOutputFileNameWithPath()
        If Not CopyFileSuccess(CType(v_strFileName, String)) Then Exit Sub

        m_objWordDocument = _
        m_objWordlApp.Documents.Open(v_strFileName _
        , m_o_missing _
        , m_o_missing _
        , m_o_missing _
        , m_o_missing _
        , m_o_missing _
        , m_o_missing _
        , m_o_missing _
        , m_o_missing _
        , m_o_missing _
        , m_o_missing _
        , m_o_missing)
        m_init_successful = True
    End Sub
    Private Sub InitPaths()
        m_strOutputPath = AppDomain.CurrentDomain.SetupInformation.ApplicationBase & c_ReportOutputDir
        m_strTemplatesPath = AppDomain.CurrentDomain.SetupInformation.ApplicationBase & c_ReportTemplatesDir
    End Sub
    Private Sub FindAndReplace(ByVal i_str_find As Object, ByVal i_str_replace_with As Object)
        m_objWordlApp.Selection.Find.ClearFormatting()
        m_objWordlApp.Selection.Find.Replacement.ClearFormatting()
        Dim v_obj_false As Object = False
        Dim v_find_forward As Object = True
        Dim v_find_wrap As Object = Word.WdFindWrap.wdFindContinue
        Dim v_find_replace As Object = Word.WdReplace.wdReplaceAll
        m_objWordlApp.Selection.Find.Execute(i_str_find _
            , m_o_missing _
            , m_o_missing _
            , m_o_missing _
            , m_o_missing _
            , m_o_missing _
            , v_find_forward _
            , v_find_wrap _
            , m_o_missing _
            , i_str_replace_with _
            , v_find_replace _
            , m_o_missing _
            , m_o_missing _
            , m_o_missing _
            , m_o_missing)
    End Sub
    Private Function CopyFileSuccess(ByVal i_strFileDest As String) As Boolean
        Try
            Dim v_objFileInfo As New FileInfo(m_strTemplateFileNameWithPath)
            Debug.Assert(v_objFileInfo.Exists(), "Khong co file template nay - tuanqt")
            v_objFileInfo.CopyTo(i_strFileDest)
            Return True
        Catch v_e As Exception
            Return False
        End Try
    End Function
    Private Sub Unmount()
        m_objWordDocument = Nothing
        m_objWordlApp = Nothing
    End Sub
#End Region
End Class

