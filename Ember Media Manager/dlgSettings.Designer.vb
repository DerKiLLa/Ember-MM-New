﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgSettings
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Catch ex As Exception
        End Try
        Try
            'Finally
            MyBase.Dispose(disposing)
        Catch ex As Exception
        End Try
    End Sub

    Delegate Sub DelegateSub(ByVal b As Boolean)

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgSettings))
        Me.gbGeneralMiscellaneous = New System.Windows.Forms.GroupBox()
        Me.chkNoDisplayFanartSmall = New System.Windows.Forms.CheckBox()
        Me.chkPosterGlassOverlay = New System.Windows.Forms.CheckBox()
        Me.chkSpecialDateAdd = New System.Windows.Forms.CheckBox()
        Me.chkShowGenresText = New System.Windows.Forms.CheckBox()
        Me.chkSourceFromFolder = New System.Windows.Forms.CheckBox()
        Me.chkNoDisplayFanart = New System.Windows.Forms.CheckBox()
        Me.chkInfoPanelAnim = New System.Windows.Forms.CheckBox()
        Me.chkNoDisplayPoster = New System.Windows.Forms.CheckBox()
        Me.chkShowDims = New System.Windows.Forms.CheckBox()
        Me.chkUpdates = New System.Windows.Forms.CheckBox()
        Me.chkOverwriteNfo = New System.Windows.Forms.CheckBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.chkLogErrors = New System.Windows.Forms.CheckBox()
        Me.GroupBox29 = New System.Windows.Forms.GroupBox()
        Me.cbEpTheme = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbTVShowTheme = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbMovieTheme = New System.Windows.Forms.ComboBox()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.cbIntLang = New System.Windows.Forms.ComboBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.tcCleaner = New System.Windows.Forms.TabControl()
        Me.tpStandard = New System.Windows.Forms.TabPage()
        Me.chkCleanFolderJPG = New System.Windows.Forms.CheckBox()
        Me.chkCleanExtrathumbs = New System.Windows.Forms.CheckBox()
        Me.chkCleanMovieTBN = New System.Windows.Forms.CheckBox()
        Me.chkCleanMovieNameJPG = New System.Windows.Forms.CheckBox()
        Me.chkCleanMovieTBNb = New System.Windows.Forms.CheckBox()
        Me.chkCleanMovieJPG = New System.Windows.Forms.CheckBox()
        Me.chkCleanFanartJPG = New System.Windows.Forms.CheckBox()
        Me.chkCleanPosterJPG = New System.Windows.Forms.CheckBox()
        Me.chkCleanMovieFanartJPG = New System.Windows.Forms.CheckBox()
        Me.chkCleanPosterTBN = New System.Windows.Forms.CheckBox()
        Me.chkCleanMovieNFO = New System.Windows.Forms.CheckBox()
        Me.chkCleanDotFanartJPG = New System.Windows.Forms.CheckBox()
        Me.chkCleanMovieNFOb = New System.Windows.Forms.CheckBox()
        Me.tpExpert = New System.Windows.Forms.TabPage()
        Me.chkWhitelistVideo = New System.Windows.Forms.CheckBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.btnRemoveWhitelist = New System.Windows.Forms.Button()
        Me.btnAddWhitelist = New System.Windows.Forms.Button()
        Me.txtWhitelist = New System.Windows.Forms.TextBox()
        Me.lstWhitelist = New System.Windows.Forms.ListBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.gbMoviesMiscellaneous = New System.Windows.Forms.GroupBox()
        Me.chkClickScrape = New System.Windows.Forms.CheckBox()
        Me.chkAskCheckboxScrape = New System.Windows.Forms.CheckBox()
        Me.chkMarkNew = New System.Windows.Forms.CheckBox()
        Me.lbGenre = New System.Windows.Forms.CheckedListBox()
        Me.gbMoviesMediaList = New System.Windows.Forms.GroupBox()
        Me.chkMovieWatchedCol = New System.Windows.Forms.CheckBox()
        Me.txtCheckTitleTol = New System.Windows.Forms.TextBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.chkCheckTitles = New System.Windows.Forms.CheckBox()
        Me.gbMoviesSortToken = New System.Windows.Forms.GroupBox()
        Me.btnRemoveToken = New System.Windows.Forms.Button()
        Me.btnAddToken = New System.Windows.Forms.Button()
        Me.txtSortToken = New System.Windows.Forms.TextBox()
        Me.lstSortTokens = New System.Windows.Forms.ListBox()
        Me.chkDisplayYear = New System.Windows.Forms.CheckBox()
        Me.chkMovieExtraCol = New System.Windows.Forms.CheckBox()
        Me.chkMovieSubCol = New System.Windows.Forms.CheckBox()
        Me.chkMovieTrailerCol = New System.Windows.Forms.CheckBox()
        Me.chkMovieInfoCol = New System.Windows.Forms.CheckBox()
        Me.chkMovieFanartCol = New System.Windows.Forms.CheckBox()
        Me.chkMoviePosterCol = New System.Windows.Forms.CheckBox()
        Me.gbSourcesFileNaming = New System.Windows.Forms.GroupBox()
        Me.btnMovieFrodo = New System.Windows.Forms.Button()
        Me.chkMovieNameMultiOnly = New System.Windows.Forms.CheckBox()
        Me.GroupBox21 = New System.Windows.Forms.GroupBox()
        Me.rbBracketTrailer = New System.Windows.Forms.RadioButton()
        Me.rbDashTrailer = New System.Windows.Forms.RadioButton()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.chkMovieNameNFOStack = New System.Windows.Forms.CheckBox()
        Me.chkMovieNameNFO = New System.Windows.Forms.CheckBox()
        Me.chkMovieNFO = New System.Windows.Forms.CheckBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.chkMovieNameDotFanartJPG = New System.Windows.Forms.CheckBox()
        Me.chkMovieNameFanartJPG = New System.Windows.Forms.CheckBox()
        Me.chkFanartJPG = New System.Windows.Forms.CheckBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.chkMovieNameDashPosterJPG = New System.Windows.Forms.CheckBox()
        Me.chkFolderJPG = New System.Windows.Forms.CheckBox()
        Me.chkPosterJPG = New System.Windows.Forms.CheckBox()
        Me.chkPosterTBN = New System.Windows.Forms.CheckBox()
        Me.chkMovieNameJPG = New System.Windows.Forms.CheckBox()
        Me.chkMovieJPG = New System.Windows.Forms.CheckBox()
        Me.chkMovieNameTBN = New System.Windows.Forms.CheckBox()
        Me.chkMovieTBN = New System.Windows.Forms.CheckBox()
        Me.lvMovies = New System.Windows.Forms.ListView()
        Me.colID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colPath = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colRecur = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colFolder = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colSingle = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnMovieRem = New System.Windows.Forms.Button()
        Me.btnMovieAddFolder = New System.Windows.Forms.Button()
        Me.gbImagesPoster = New System.Windows.Forms.GroupBox()
        Me.chkPosterOnly = New System.Windows.Forms.CheckBox()
        Me.txtPosterWidth = New System.Windows.Forms.TextBox()
        Me.txtPosterHeight = New System.Windows.Forms.TextBox()
        Me.lblPosterQual = New System.Windows.Forms.Label()
        Me.tbPosterQual = New System.Windows.Forms.TrackBar()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.chkResizePoster = New System.Windows.Forms.CheckBox()
        Me.lblPosterSize = New System.Windows.Forms.Label()
        Me.cbPosterSize = New System.Windows.Forms.ComboBox()
        Me.chkOverwritePoster = New System.Windows.Forms.CheckBox()
        Me.gbImagesFanart = New System.Windows.Forms.GroupBox()
        Me.txtFanartWidth = New System.Windows.Forms.TextBox()
        Me.txtFanartHeight = New System.Windows.Forms.TextBox()
        Me.chkFanartOnly = New System.Windows.Forms.CheckBox()
        Me.lblFanartQual = New System.Windows.Forms.Label()
        Me.tbFanartQual = New System.Windows.Forms.TrackBar()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.chkResizeFanart = New System.Windows.Forms.CheckBox()
        Me.cbFanartSize = New System.Windows.Forms.ComboBox()
        Me.lblFanartSize = New System.Windows.Forms.Label()
        Me.chkOverwriteFanart = New System.Windows.Forms.CheckBox()
        Me.gbImagesImages = New System.Windows.Forms.GroupBox()
        Me.chkScraperActorThumbs = New System.Windows.Forms.CheckBox()
        Me.chkNoSaveImagesToNfo = New System.Windows.Forms.CheckBox()
        Me.chkSingleScrapeImages = New System.Windows.Forms.CheckBox()
        Me.gbImagesCaching = New System.Windows.Forms.GroupBox()
        Me.chkUseImgCacheUpdaters = New System.Windows.Forms.CheckBox()
        Me.chkPersistImgCache = New System.Windows.Forms.CheckBox()
        Me.chkUseImgCache = New System.Windows.Forms.CheckBox()
        Me.chkUseETasFA = New System.Windows.Forms.CheckBox()
        Me.chkNoSpoilers = New System.Windows.Forms.CheckBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtAutoThumbs = New System.Windows.Forms.TextBox()
        Me.chkAutoThumbs = New System.Windows.Forms.CheckBox()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.btnApply = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.pnlTop = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ilSettings = New System.Windows.Forms.ImageList(Me.components)
        Me.tvSettings = New System.Windows.Forms.TreeView()
        Me.pnlGeneral = New System.Windows.Forms.Panel()
        Me.gbGeneralInterface = New System.Windows.Forms.GroupBox()
        Me.pnlXBMCCom = New System.Windows.Forms.Panel()
        Me.gbProxy = New System.Windows.Forms.GroupBox()
        Me.gbCreds = New System.Windows.Forms.GroupBox()
        Me.txtProxyDomain = New System.Windows.Forms.TextBox()
        Me.lblProxyDomain = New System.Windows.Forms.Label()
        Me.txtProxyPassword = New System.Windows.Forms.TextBox()
        Me.txtProxyUsername = New System.Windows.Forms.TextBox()
        Me.lblProxyUN = New System.Windows.Forms.Label()
        Me.lblProxyPW = New System.Windows.Forms.Label()
        Me.chkEnableCredentials = New System.Windows.Forms.CheckBox()
        Me.lblProxyPort = New System.Windows.Forms.Label()
        Me.lblProxyURI = New System.Windows.Forms.Label()
        Me.txtProxyPort = New System.Windows.Forms.TextBox()
        Me.txtProxyURI = New System.Windows.Forms.TextBox()
        Me.chkEnableProxy = New System.Windows.Forms.CheckBox()
        Me.pnlMovies = New System.Windows.Forms.Panel()
        Me.gbMoviesGenreFilter = New System.Windows.Forms.GroupBox()
        Me.gbMoviesFilters = New System.Windows.Forms.GroupBox()
        Me.btnResetMovieFilters = New System.Windows.Forms.Button()
        Me.btnDown = New System.Windows.Forms.Button()
        Me.btnUp = New System.Windows.Forms.Button()
        Me.chkProperCase = New System.Windows.Forms.CheckBox()
        Me.btnRemoveFilter = New System.Windows.Forms.Button()
        Me.btnAddFilter = New System.Windows.Forms.Button()
        Me.txtFilter = New System.Windows.Forms.TextBox()
        Me.lstFilters = New System.Windows.Forms.ListBox()
        Me.gbMoviesMissingFilter = New System.Windows.Forms.GroupBox()
        Me.chkMissingExtra = New System.Windows.Forms.CheckBox()
        Me.chkMissingSubs = New System.Windows.Forms.CheckBox()
        Me.chkMissingTrailer = New System.Windows.Forms.CheckBox()
        Me.chkMissingNFO = New System.Windows.Forms.CheckBox()
        Me.chkMissingFanart = New System.Windows.Forms.CheckBox()
        Me.chkMissingPoster = New System.Windows.Forms.CheckBox()
        Me.gbSourcesBackdrops = New System.Windows.Forms.GroupBox()
        Me.chkAutoBD = New System.Windows.Forms.CheckBox()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.txtBDPath = New System.Windows.Forms.TextBox()
        Me.lblCurrent = New System.Windows.Forms.Label()
        Me.pnlCurrent = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.pbCurrent = New System.Windows.Forms.PictureBox()
        Me.pnlExtensions = New System.Windows.Forms.Panel()
        Me.GroupBox22 = New System.Windows.Forms.GroupBox()
        Me.btnRemoveNoStack = New System.Windows.Forms.Button()
        Me.btnAddNoStack = New System.Windows.Forms.Button()
        Me.txtNoStack = New System.Windows.Forms.TextBox()
        Me.lstNoStack = New System.Windows.Forms.ListBox()
        Me.GroupBox18 = New System.Windows.Forms.GroupBox()
        Me.btnResetValidExts = New System.Windows.Forms.Button()
        Me.btnRemMovieExt = New System.Windows.Forms.Button()
        Me.btnAddMovieExt = New System.Windows.Forms.Button()
        Me.txtMovieExt = New System.Windows.Forms.TextBox()
        Me.lstMovieExts = New System.Windows.Forms.ListBox()
        Me.pnlSources = New System.Windows.Forms.Panel()
        Me.btnEditSource = New System.Windows.Forms.Button()
        Me.gbSourcesMiscellaneous = New System.Windows.Forms.GroupBox()
        Me.chkVideoTSParentXBMC = New System.Windows.Forms.CheckBox()
        Me.chkScanOrderModify = New System.Windows.Forms.CheckBox()
        Me.chkSortBeforeScan = New System.Windows.Forms.CheckBox()
        Me.chkIgnoreLastScan = New System.Windows.Forms.CheckBox()
        Me.chkCleanDB = New System.Windows.Forms.CheckBox()
        Me.chkAutoDetectVTS = New System.Windows.Forms.CheckBox()
        Me.chkSkipStackedSizeCheck = New System.Windows.Forms.CheckBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txtSkipLessThan = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.pnlImages = New System.Windows.Forms.Panel()
        Me.gbImagesTrailers = New System.Windows.Forms.GroupBox()
        Me.cbTrailerQuality = New System.Windows.Forms.ComboBox()
        Me.lblPreferredQuality = New System.Windows.Forms.Label()
        Me.chkDeleteAllTrailers = New System.Windows.Forms.CheckBox()
        Me.chkOverwriteTrailer = New System.Windows.Forms.CheckBox()
        Me.chkNoDLTrailer = New System.Windows.Forms.CheckBox()
        Me.chkSingleScrapeTrailer = New System.Windows.Forms.CheckBox()
        Me.chkUpdaterTrailer = New System.Windows.Forms.CheckBox()
        Me.chkDownloadTrailer = New System.Windows.Forms.CheckBox()
        Me.gbImagesExtrathumbs = New System.Windows.Forms.GroupBox()
        Me.chkAutoETSize = New System.Windows.Forms.CheckBox()
        Me.cbAutoETSize = New System.Windows.Forms.ComboBox()
        Me.gbImagesSizing = New System.Windows.Forms.GroupBox()
        Me.txtETWidth = New System.Windows.Forms.TextBox()
        Me.txtETHeight = New System.Windows.Forms.TextBox()
        Me.chkETPadding = New System.Windows.Forms.CheckBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.rbETCustom = New System.Windows.Forms.RadioButton()
        Me.rbETNative = New System.Windows.Forms.RadioButton()
        Me.fbdBrowse = New System.Windows.Forms.FolderBrowserDialog()
        Me.ToolTips = New System.Windows.Forms.ToolTip(Me.components)
        Me.pnlTVSources = New System.Windows.Forms.Panel()
        Me.TabControl2 = New System.Windows.Forms.TabControl()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.btnTVShowFrodo = New System.Windows.Forms.Button()
        Me.lvTVSources = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.gbMiscTVSourceOpts = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtTVSkipLessThan = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.chkTVScanOrderModify = New System.Windows.Forms.CheckBox()
        Me.chkTVIgnoreLastScan = New System.Windows.Forms.CheckBox()
        Me.chkTVCleanDB = New System.Windows.Forms.CheckBox()
        Me.btnAddTVSource = New System.Windows.Forms.Button()
        Me.btnEditTVSource = New System.Windows.Forms.Button()
        Me.btnRemTVSource = New System.Windows.Forms.Button()
        Me.gbTVNaming = New System.Windows.Forms.GroupBox()
        Me.gbShowBanner = New System.Windows.Forms.GroupBox()
        Me.chkShowBannerJPG = New System.Windows.Forms.CheckBox()
        Me.gbAllSeasonPoster = New System.Windows.Forms.GroupBox()
        Me.chkSeasonAllPosterJPG = New System.Windows.Forms.CheckBox()
        Me.chkSeasonAllJPG = New System.Windows.Forms.CheckBox()
        Me.chkSeasonAllTBN = New System.Windows.Forms.CheckBox()
        Me.gbEpisodeFanart = New System.Windows.Forms.GroupBox()
        Me.chkEpisodeDotFanart = New System.Windows.Forms.CheckBox()
        Me.chkEpisodeDashFanart = New System.Windows.Forms.CheckBox()
        Me.gbEpisodePosters = New System.Windows.Forms.GroupBox()
        Me.chkEpisodeDashThumbJPG = New System.Windows.Forms.CheckBox()
        Me.chkEpisodeJPG = New System.Windows.Forms.CheckBox()
        Me.chkEpisodeTBN = New System.Windows.Forms.CheckBox()
        Me.gbSeasonFanart = New System.Windows.Forms.GroupBox()
        Me.chkSeasonXXDashFanartJPG = New System.Windows.Forms.CheckBox()
        Me.chkSeasonDotFanart = New System.Windows.Forms.CheckBox()
        Me.chkSeasonDashFanart = New System.Windows.Forms.CheckBox()
        Me.chkSeasonFanartJPG = New System.Windows.Forms.CheckBox()
        Me.gbSeasonPosters = New System.Windows.Forms.GroupBox()
        Me.chkSeasonXXDashPosterJPG = New System.Windows.Forms.CheckBox()
        Me.chkSeasonFolderJPG = New System.Windows.Forms.CheckBox()
        Me.chkSeasonNameJPG = New System.Windows.Forms.CheckBox()
        Me.chkSeasonNameTBN = New System.Windows.Forms.CheckBox()
        Me.chkSeasonPosterJPG = New System.Windows.Forms.CheckBox()
        Me.chkSeasonPosterTBN = New System.Windows.Forms.CheckBox()
        Me.chkSeasonXTBN = New System.Windows.Forms.CheckBox()
        Me.chkSeasonXXTBN = New System.Windows.Forms.CheckBox()
        Me.gbShowFanart = New System.Windows.Forms.GroupBox()
        Me.chkShowDotFanart = New System.Windows.Forms.CheckBox()
        Me.chkShowDashFanart = New System.Windows.Forms.CheckBox()
        Me.chkShowFanartJPG = New System.Windows.Forms.CheckBox()
        Me.gbShowPosters = New System.Windows.Forms.GroupBox()
        Me.chkShowJPG = New System.Windows.Forms.CheckBox()
        Me.chkShowTBN = New System.Windows.Forms.CheckBox()
        Me.chkShowPosterJPG = New System.Windows.Forms.CheckBox()
        Me.chkShowPosterTBN = New System.Windows.Forms.CheckBox()
        Me.chkShowFolderJPG = New System.Windows.Forms.CheckBox()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.btnGetTVProfiles = New System.Windows.Forms.Button()
        Me.btnRegexDown = New System.Windows.Forms.Button()
        Me.btnRegexUp = New System.Windows.Forms.Button()
        Me.btnResetShowRegex = New System.Windows.Forms.Button()
        Me.gbShowRegex = New System.Windows.Forms.GroupBox()
        Me.btnClearRegex = New System.Windows.Forms.Button()
        Me.lblSeasonMatch = New System.Windows.Forms.Label()
        Me.btnAddShowRegex = New System.Windows.Forms.Button()
        Me.txtSeasonRegex = New System.Windows.Forms.TextBox()
        Me.lblEpisodeRetrieve = New System.Windows.Forms.Label()
        Me.cboSeasonRetrieve = New System.Windows.Forms.ComboBox()
        Me.lblSeasonRetrieve = New System.Windows.Forms.Label()
        Me.txtEpRegex = New System.Windows.Forms.TextBox()
        Me.lblEpisodeMatch = New System.Windows.Forms.Label()
        Me.cboEpRetrieve = New System.Windows.Forms.ComboBox()
        Me.btnEditShowRegex = New System.Windows.Forms.Button()
        Me.btnRemoveShowRegex = New System.Windows.Forms.Button()
        Me.lvShowRegex = New System.Windows.Forms.ListView()
        Me.colRegID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colSeason = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colSeasonApply = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colEpisode = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colEpApply = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.pnlShows = New System.Windows.Forms.Panel()
        Me.gbShowMediaList = New System.Windows.Forms.GroupBox()
        Me.chkDisplayMissingEpisodes = New System.Windows.Forms.CheckBox()
        Me.gbEpisodeListOptions = New System.Windows.Forms.GroupBox()
        Me.chkEpisodeWatchedCol = New System.Windows.Forms.CheckBox()
        Me.chkEpisodeNfoCol = New System.Windows.Forms.CheckBox()
        Me.chkEpisodeFanartCol = New System.Windows.Forms.CheckBox()
        Me.chkEpisodePosterCol = New System.Windows.Forms.CheckBox()
        Me.gbSeasonListOptions = New System.Windows.Forms.GroupBox()
        Me.chkSeasonFanartCol = New System.Windows.Forms.CheckBox()
        Me.chkSeasonPosterCol = New System.Windows.Forms.CheckBox()
        Me.gbShowListOptions = New System.Windows.Forms.GroupBox()
        Me.chkShowNfoCol = New System.Windows.Forms.CheckBox()
        Me.chkShowFanartCol = New System.Windows.Forms.CheckBox()
        Me.chkShowPosterCol = New System.Windows.Forms.CheckBox()
        Me.gbShowsMiscellaneous = New System.Windows.Forms.GroupBox()
        Me.chkMarkNewShows = New System.Windows.Forms.CheckBox()
        Me.chkMarkNewEpisodes = New System.Windows.Forms.CheckBox()
        Me.chkDisplayAllSeason = New System.Windows.Forms.CheckBox()
        Me.lblRatingRegion = New System.Windows.Forms.Label()
        Me.cbRatingRegion = New System.Windows.Forms.ComboBox()
        Me.gbShowEpFilter = New System.Windows.Forms.GroupBox()
        Me.btnResetEpFilter = New System.Windows.Forms.Button()
        Me.chkNoFilterEpisode = New System.Windows.Forms.CheckBox()
        Me.btnEpFilterDown = New System.Windows.Forms.Button()
        Me.btnEpFilterUp = New System.Windows.Forms.Button()
        Me.chkEpProperCase = New System.Windows.Forms.CheckBox()
        Me.btnRemoveEpFilter = New System.Windows.Forms.Button()
        Me.btnAddEpFilter = New System.Windows.Forms.Button()
        Me.txtEpFilter = New System.Windows.Forms.TextBox()
        Me.lstEpFilters = New System.Windows.Forms.ListBox()
        Me.gbShowFilter = New System.Windows.Forms.GroupBox()
        Me.btnResetShowFilters = New System.Windows.Forms.Button()
        Me.btnShowFilterDown = New System.Windows.Forms.Button()
        Me.btnShowFilterUp = New System.Windows.Forms.Button()
        Me.chkShowProperCase = New System.Windows.Forms.CheckBox()
        Me.btnRemoveShowFilter = New System.Windows.Forms.Button()
        Me.btnAddShowFilter = New System.Windows.Forms.Button()
        Me.txtShowFilter = New System.Windows.Forms.TextBox()
        Me.lstShowFilters = New System.Windows.Forms.ListBox()
        Me.pnlTVImages = New System.Windows.Forms.Panel()
        Me.TabControl3 = New System.Windows.Forms.TabControl()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.gbAllSPosterOpts = New System.Windows.Forms.GroupBox()
        Me.rbAllSPoster = New System.Windows.Forms.RadioButton()
        Me.rbAllSBanner = New System.Windows.Forms.RadioButton()
        Me.txtAllSPosterWidth = New System.Windows.Forms.TextBox()
        Me.txtAllSPosterHeight = New System.Windows.Forms.TextBox()
        Me.lblAllSPosterQual = New System.Windows.Forms.Label()
        Me.tbAllSPosterQual = New System.Windows.Forms.TrackBar()
        Me.lblAllSPosterQ = New System.Windows.Forms.Label()
        Me.lblAllSPosterWidth = New System.Windows.Forms.Label()
        Me.lblAllSPosterHeight = New System.Windows.Forms.Label()
        Me.chkResizeAllSPoster = New System.Windows.Forms.CheckBox()
        Me.lblAllSPosterSize = New System.Windows.Forms.Label()
        Me.cbAllSPosterSize = New System.Windows.Forms.ComboBox()
        Me.chkOverwriteAllSPoster = New System.Windows.Forms.CheckBox()
        Me.gbShowPosterOpts = New System.Windows.Forms.GroupBox()
        Me.rbPoster = New System.Windows.Forms.RadioButton()
        Me.rbBanner = New System.Windows.Forms.RadioButton()
        Me.txtShowPosterWidth = New System.Windows.Forms.TextBox()
        Me.txtShowPosterHeight = New System.Windows.Forms.TextBox()
        Me.lblShowPosterQual = New System.Windows.Forms.Label()
        Me.tbShowPosterQual = New System.Windows.Forms.TrackBar()
        Me.lblShowPosterQ = New System.Windows.Forms.Label()
        Me.lblShowPosterWidth = New System.Windows.Forms.Label()
        Me.lblShowPosterHeight = New System.Windows.Forms.Label()
        Me.chkResizeShowPoster = New System.Windows.Forms.CheckBox()
        Me.lblShowPosterSize = New System.Windows.Forms.Label()
        Me.cbShowPosterSize = New System.Windows.Forms.ComboBox()
        Me.chkOverwriteShowPoster = New System.Windows.Forms.CheckBox()
        Me.gbShowFanartOpts = New System.Windows.Forms.GroupBox()
        Me.txtShowFanartWidth = New System.Windows.Forms.TextBox()
        Me.txtShowFanartHeight = New System.Windows.Forms.TextBox()
        Me.lblShowFanartQual = New System.Windows.Forms.Label()
        Me.tbShowFanartQual = New System.Windows.Forms.TrackBar()
        Me.lblShowFanartQ = New System.Windows.Forms.Label()
        Me.lblShowFanartWidth = New System.Windows.Forms.Label()
        Me.lblShowFanartHeight = New System.Windows.Forms.Label()
        Me.chkResizeShowFanart = New System.Windows.Forms.CheckBox()
        Me.cbShowFanartSize = New System.Windows.Forms.ComboBox()
        Me.lblShowFanartSize = New System.Windows.Forms.Label()
        Me.chkOverwriteShowFanart = New System.Windows.Forms.CheckBox()
        Me.TabPage6 = New System.Windows.Forms.TabPage()
        Me.gbSeaPosterOpts = New System.Windows.Forms.GroupBox()
        Me.txtSeaPosterWidth = New System.Windows.Forms.TextBox()
        Me.txtSeaPosterHeight = New System.Windows.Forms.TextBox()
        Me.lblSeaPosterQual = New System.Windows.Forms.Label()
        Me.tbSeaPosterQual = New System.Windows.Forms.TrackBar()
        Me.lblSeaPosterQ = New System.Windows.Forms.Label()
        Me.lblSeaPosterWidth = New System.Windows.Forms.Label()
        Me.lblSeaPosterHeight = New System.Windows.Forms.Label()
        Me.chkSeaResizePoster = New System.Windows.Forms.CheckBox()
        Me.lblSeaPosterSize = New System.Windows.Forms.Label()
        Me.cbSeaPosterSize = New System.Windows.Forms.ComboBox()
        Me.chkSeaOverwritePoster = New System.Windows.Forms.CheckBox()
        Me.gbSeaFanartOpts = New System.Windows.Forms.GroupBox()
        Me.txtSeaFanartWidth = New System.Windows.Forms.TextBox()
        Me.txtSeaFanartHeight = New System.Windows.Forms.TextBox()
        Me.lblSeaFanartQual = New System.Windows.Forms.Label()
        Me.tbSeaFanartQual = New System.Windows.Forms.TrackBar()
        Me.lblSeaFanartQ = New System.Windows.Forms.Label()
        Me.lblSeaFanartWidth = New System.Windows.Forms.Label()
        Me.lblSeaFanartHeight = New System.Windows.Forms.Label()
        Me.chkSeaResizeFanart = New System.Windows.Forms.CheckBox()
        Me.cbSeaFanartSize = New System.Windows.Forms.ComboBox()
        Me.lblSeaFanartSize = New System.Windows.Forms.Label()
        Me.chkSeaOverwriteFanart = New System.Windows.Forms.CheckBox()
        Me.TabPage7 = New System.Windows.Forms.TabPage()
        Me.gbEpPosterOpts = New System.Windows.Forms.GroupBox()
        Me.txtEpPosterWidth = New System.Windows.Forms.TextBox()
        Me.txtEpPosterHeight = New System.Windows.Forms.TextBox()
        Me.lblEpPosterQual = New System.Windows.Forms.Label()
        Me.tbEpPosterQual = New System.Windows.Forms.TrackBar()
        Me.lblEpPosterQ = New System.Windows.Forms.Label()
        Me.lblEpPosterWidth = New System.Windows.Forms.Label()
        Me.lblEpPosterHeight = New System.Windows.Forms.Label()
        Me.chkResizeEpPoster = New System.Windows.Forms.CheckBox()
        Me.chkOverwriteEpPoster = New System.Windows.Forms.CheckBox()
        Me.gbEpFanartOpts = New System.Windows.Forms.GroupBox()
        Me.txtEpFanartWidth = New System.Windows.Forms.TextBox()
        Me.txtEpFanartHeight = New System.Windows.Forms.TextBox()
        Me.lblEpFanartQual = New System.Windows.Forms.Label()
        Me.tbEpFanartQual = New System.Windows.Forms.TrackBar()
        Me.lblEpFanartQ = New System.Windows.Forms.Label()
        Me.lblEpFanartWidth = New System.Windows.Forms.Label()
        Me.lblEpFanartHeight = New System.Windows.Forms.Label()
        Me.chkResizeEpFanart = New System.Windows.Forms.CheckBox()
        Me.cbEpFanartSize = New System.Windows.Forms.ComboBox()
        Me.lblEpFanartSize = New System.Windows.Forms.Label()
        Me.chkOverwriteEpFanart = New System.Windows.Forms.CheckBox()
        Me.TabPage8 = New System.Windows.Forms.TabPage()
        Me.chkGetEnglishImages = New System.Windows.Forms.CheckBox()
        Me.chkOnlyTVImagesLanguage = New System.Windows.Forms.CheckBox()
        Me.pnlTVScraper = New System.Windows.Forms.Panel()
        Me.gbTVScraperDuration = New System.Windows.Forms.GroupBox()
        Me.txtEPRuntimeFormat = New System.Windows.Forms.TextBox()
        Me.chkUseEPDuration = New System.Windows.Forms.CheckBox()
        Me.gbTVScraperGlobalLocks = New System.Windows.Forms.GroupBox()
        Me.gbTVScraperEpLocks = New System.Windows.Forms.GroupBox()
        Me.chkEpLockTitle = New System.Windows.Forms.CheckBox()
        Me.chkEpLockRating = New System.Windows.Forms.CheckBox()
        Me.chkEpLockPlot = New System.Windows.Forms.CheckBox()
        Me.gbTVScraperShowLocks = New System.Windows.Forms.GroupBox()
        Me.chkShowLockPlot = New System.Windows.Forms.CheckBox()
        Me.chkShowLockGenre = New System.Windows.Forms.CheckBox()
        Me.chkShowLockStudio = New System.Windows.Forms.CheckBox()
        Me.chkShowLockRating = New System.Windows.Forms.CheckBox()
        Me.chkShowLockTitle = New System.Windows.Forms.CheckBox()
        Me.gbTVScraperMetaData = New System.Windows.Forms.GroupBox()
        Me.gbTVScraperFileType = New System.Windows.Forms.GroupBox()
        Me.lstTVMetaData = New System.Windows.Forms.ListBox()
        Me.txtTVDefFIExt = New System.Windows.Forms.TextBox()
        Me.Label49 = New System.Windows.Forms.Label()
        Me.btnRemoveTVMetaDataFT = New System.Windows.Forms.Button()
        Me.btnEditTVMetaDataFT = New System.Windows.Forms.Button()
        Me.btnNewTVMetaDataFT = New System.Windows.Forms.Button()
        Me.cboTVMetaDataOverlay = New System.Windows.Forms.ComboBox()
        Me.Label50 = New System.Windows.Forms.Label()
        Me.chkTVScanMetaData = New System.Windows.Forms.CheckBox()
        Me.gbTVScraperOptions = New System.Windows.Forms.GroupBox()
        Me.lblOrdering = New System.Windows.Forms.Label()
        Me.cbOrdering = New System.Windows.Forms.ComboBox()
        Me.lblTVUpdate = New System.Windows.Forms.Label()
        Me.cboTVUpdate = New System.Windows.Forms.ComboBox()
        Me.lblAPIKey = New System.Windows.Forms.Label()
        Me.lblTVDBMirror = New System.Windows.Forms.Label()
        Me.txtAPIKey = New System.Windows.Forms.TextBox()
        Me.txtTVDBMirror = New System.Windows.Forms.TextBox()
        Me.gbTVScraperLanguage = New System.Windows.Forms.GroupBox()
        Me.lblTVLanguagePreferred = New System.Windows.Forms.Label()
        Me.btnTVLanguageFetch = New System.Windows.Forms.Button()
        Me.cbTVLanguage = New System.Windows.Forms.ComboBox()
        Me.gbTVScraperFields = New System.Windows.Forms.GroupBox()
        Me.gbTVScraperShow = New System.Windows.Forms.GroupBox()
        Me.chkScraperShowRating = New System.Windows.Forms.CheckBox()
        Me.chkScraperShowActors = New System.Windows.Forms.CheckBox()
        Me.chkScraperShowStudio = New System.Windows.Forms.CheckBox()
        Me.chkScraperShowPremiered = New System.Windows.Forms.CheckBox()
        Me.chkScraperShowEGU = New System.Windows.Forms.CheckBox()
        Me.chkScraperShowMPAA = New System.Windows.Forms.CheckBox()
        Me.chkScraperShowPlot = New System.Windows.Forms.CheckBox()
        Me.chkScraperShowGenre = New System.Windows.Forms.CheckBox()
        Me.chkScraperShowTitle = New System.Windows.Forms.CheckBox()
        Me.gbTVScraperEpisode = New System.Windows.Forms.GroupBox()
        Me.chkScraperEpActors = New System.Windows.Forms.CheckBox()
        Me.chkScraperEpCredits = New System.Windows.Forms.CheckBox()
        Me.chkScraperEpDirector = New System.Windows.Forms.CheckBox()
        Me.chkScraperEpPlot = New System.Windows.Forms.CheckBox()
        Me.chkScraperEpRating = New System.Windows.Forms.CheckBox()
        Me.chkScraperEpAired = New System.Windows.Forms.CheckBox()
        Me.chkScraperEpTitle = New System.Windows.Forms.CheckBox()
        Me.chkScraperEpEpisode = New System.Windows.Forms.CheckBox()
        Me.chkScraperEpSeason = New System.Windows.Forms.CheckBox()
        Me.pnlMain = New System.Windows.Forms.Panel()
        Me.gbScraperFields = New System.Windows.Forms.GroupBox()
        Me.chkCertification = New System.Windows.Forms.CheckBox()
        Me.chkTop250 = New System.Windows.Forms.CheckBox()
        Me.chkCountry = New System.Windows.Forms.CheckBox()
        Me.txtGenreLimit = New System.Windows.Forms.TextBox()
        Me.lblLimit2 = New System.Windows.Forms.Label()
        Me.txtActorLimit = New System.Windows.Forms.TextBox()
        Me.lblLimit = New System.Windows.Forms.Label()
        Me.chkCrew = New System.Windows.Forms.CheckBox()
        Me.chkMusicBy = New System.Windows.Forms.CheckBox()
        Me.chkProducers = New System.Windows.Forms.CheckBox()
        Me.chkWriters = New System.Windows.Forms.CheckBox()
        Me.chkStudio = New System.Windows.Forms.CheckBox()
        Me.chkRuntime = New System.Windows.Forms.CheckBox()
        Me.chkPlot = New System.Windows.Forms.CheckBox()
        Me.chkOutline = New System.Windows.Forms.CheckBox()
        Me.chkGenre = New System.Windows.Forms.CheckBox()
        Me.chkDirector = New System.Windows.Forms.CheckBox()
        Me.chkTagline = New System.Windows.Forms.CheckBox()
        Me.chkCast = New System.Windows.Forms.CheckBox()
        Me.chkVotes = New System.Windows.Forms.CheckBox()
        Me.chkTrailer = New System.Windows.Forms.CheckBox()
        Me.chkRating = New System.Windows.Forms.CheckBox()
        Me.chkRelease = New System.Windows.Forms.CheckBox()
        Me.chkMPAA = New System.Windows.Forms.CheckBox()
        Me.chkYear = New System.Windows.Forms.CheckBox()
        Me.chkTitle = New System.Windows.Forms.CheckBox()
        Me.gbScraperMetaData = New System.Windows.Forms.GroupBox()
        Me.gbScraperFileType = New System.Windows.Forms.GroupBox()
        Me.lstMetaData = New System.Windows.Forms.ListBox()
        Me.txtDefFIExt = New System.Windows.Forms.TextBox()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.btnRemoveMetaDataFT = New System.Windows.Forms.Button()
        Me.btnEditMetaDataFT = New System.Windows.Forms.Button()
        Me.btnNewMetaDataFT = New System.Windows.Forms.Button()
        Me.chkIFOScan = New System.Windows.Forms.CheckBox()
        Me.cbLanguages = New System.Windows.Forms.ComboBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.gbScraperDurationFormat = New System.Windows.Forms.GroupBox()
        Me.Label51 = New System.Windows.Forms.Label()
        Me.txtRuntimeFormat = New System.Windows.Forms.TextBox()
        Me.chkUseMIDuration = New System.Windows.Forms.CheckBox()
        Me.chkScanMediaInfo = New System.Windows.Forms.CheckBox()
        Me.gbScraperGlobalLocks = New System.Windows.Forms.GroupBox()
        Me.chkLockSubtitle = New System.Windows.Forms.CheckBox()
        Me.chkLockMPAA = New System.Windows.Forms.CheckBox()
        Me.chkLockLanguageA = New System.Windows.Forms.CheckBox()
        Me.chkLockLanguageV = New System.Windows.Forms.CheckBox()
        Me.chkLockOutline = New System.Windows.Forms.CheckBox()
        Me.chkLockPlot = New System.Windows.Forms.CheckBox()
        Me.chkLockTrailer = New System.Windows.Forms.CheckBox()
        Me.chkLockGenre = New System.Windows.Forms.CheckBox()
        Me.chkLockRealStudio = New System.Windows.Forms.CheckBox()
        Me.chkLockRating = New System.Windows.Forms.CheckBox()
        Me.chkLockTagline = New System.Windows.Forms.CheckBox()
        Me.chkLockTitle = New System.Windows.Forms.CheckBox()
        Me.gbScraperMiscellaneous = New System.Windows.Forms.GroupBox()
        Me.txtOutlineLimit = New System.Windows.Forms.TextBox()
        Me.chkPlotForOutline = New System.Windows.Forms.CheckBox()
        Me.chkUseMPAAFSK = New System.Windows.Forms.CheckBox()
        Me.chkOnlyValueForCert = New System.Windows.Forms.CheckBox()
        Me.cbForce = New System.Windows.Forms.ComboBox()
        Me.chkForceTitle = New System.Windows.Forms.CheckBox()
        Me.chkOutlineForPlot = New System.Windows.Forms.CheckBox()
        Me.chkCastWithImg = New System.Windows.Forms.CheckBox()
        Me.chkUseCertForMPAA = New System.Windows.Forms.CheckBox()
        Me.chkFullCast = New System.Windows.Forms.CheckBox()
        Me.chkFullCrew = New System.Windows.Forms.CheckBox()
        Me.cbCert = New System.Windows.Forms.ComboBox()
        Me.chkCert = New System.Windows.Forms.CheckBox()
        Me.pnlScraper = New System.Windows.Forms.Panel()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.gbHelp = New System.Windows.Forms.GroupBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.lblHelp = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.gbGeneralMiscellaneous.SuspendLayout()
        Me.GroupBox29.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.tcCleaner.SuspendLayout()
        Me.tpStandard.SuspendLayout()
        Me.tpExpert.SuspendLayout()
        Me.gbMoviesMiscellaneous.SuspendLayout()
        Me.gbMoviesMediaList.SuspendLayout()
        Me.gbMoviesSortToken.SuspendLayout()
        Me.gbSourcesFileNaming.SuspendLayout()
        Me.GroupBox21.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.gbImagesPoster.SuspendLayout()
        CType(Me.tbPosterQual, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbImagesFanart.SuspendLayout()
        CType(Me.tbFanartQual, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbImagesImages.SuspendLayout()
        Me.gbImagesCaching.SuspendLayout()
        Me.pnlTop.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlGeneral.SuspendLayout()
        Me.gbGeneralInterface.SuspendLayout()
        Me.pnlXBMCCom.SuspendLayout()
        Me.gbProxy.SuspendLayout()
        Me.gbCreds.SuspendLayout()
        Me.pnlMovies.SuspendLayout()
        Me.gbMoviesGenreFilter.SuspendLayout()
        Me.gbMoviesFilters.SuspendLayout()
        Me.gbMoviesMissingFilter.SuspendLayout()
        Me.gbSourcesBackdrops.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.pbCurrent, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlExtensions.SuspendLayout()
        Me.GroupBox22.SuspendLayout()
        Me.GroupBox18.SuspendLayout()
        Me.pnlSources.SuspendLayout()
        Me.gbSourcesMiscellaneous.SuspendLayout()
        Me.pnlImages.SuspendLayout()
        Me.gbImagesTrailers.SuspendLayout()
        Me.gbImagesExtrathumbs.SuspendLayout()
        Me.gbImagesSizing.SuspendLayout()
        Me.pnlTVSources.SuspendLayout()
        Me.TabControl2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.gbMiscTVSourceOpts.SuspendLayout()
        Me.gbTVNaming.SuspendLayout()
        Me.gbShowBanner.SuspendLayout()
        Me.gbAllSeasonPoster.SuspendLayout()
        Me.gbEpisodeFanart.SuspendLayout()
        Me.gbEpisodePosters.SuspendLayout()
        Me.gbSeasonFanart.SuspendLayout()
        Me.gbSeasonPosters.SuspendLayout()
        Me.gbShowFanart.SuspendLayout()
        Me.gbShowPosters.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.gbShowRegex.SuspendLayout()
        Me.pnlShows.SuspendLayout()
        Me.gbShowMediaList.SuspendLayout()
        Me.gbEpisodeListOptions.SuspendLayout()
        Me.gbSeasonListOptions.SuspendLayout()
        Me.gbShowListOptions.SuspendLayout()
        Me.gbShowsMiscellaneous.SuspendLayout()
        Me.gbShowEpFilter.SuspendLayout()
        Me.gbShowFilter.SuspendLayout()
        Me.pnlTVImages.SuspendLayout()
        Me.TabControl3.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        Me.gbAllSPosterOpts.SuspendLayout()
        CType(Me.tbAllSPosterQual, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbShowPosterOpts.SuspendLayout()
        CType(Me.tbShowPosterQual, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbShowFanartOpts.SuspendLayout()
        CType(Me.tbShowFanartQual, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage6.SuspendLayout()
        Me.gbSeaPosterOpts.SuspendLayout()
        CType(Me.tbSeaPosterQual, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbSeaFanartOpts.SuspendLayout()
        CType(Me.tbSeaFanartQual, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage7.SuspendLayout()
        Me.gbEpPosterOpts.SuspendLayout()
        CType(Me.tbEpPosterQual, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbEpFanartOpts.SuspendLayout()
        CType(Me.tbEpFanartQual, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage8.SuspendLayout()
        Me.pnlTVScraper.SuspendLayout()
        Me.gbTVScraperDuration.SuspendLayout()
        Me.gbTVScraperGlobalLocks.SuspendLayout()
        Me.gbTVScraperEpLocks.SuspendLayout()
        Me.gbTVScraperShowLocks.SuspendLayout()
        Me.gbTVScraperMetaData.SuspendLayout()
        Me.gbTVScraperFileType.SuspendLayout()
        Me.gbTVScraperOptions.SuspendLayout()
        Me.gbTVScraperLanguage.SuspendLayout()
        Me.gbTVScraperFields.SuspendLayout()
        Me.gbTVScraperShow.SuspendLayout()
        Me.gbTVScraperEpisode.SuspendLayout()
        Me.gbScraperFields.SuspendLayout()
        Me.gbScraperMetaData.SuspendLayout()
        Me.gbScraperFileType.SuspendLayout()
        Me.gbScraperDurationFormat.SuspendLayout()
        Me.gbScraperGlobalLocks.SuspendLayout()
        Me.gbScraperMiscellaneous.SuspendLayout()
        Me.pnlScraper.SuspendLayout()
        Me.gbHelp.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbGeneralMiscellaneous
        '
        Me.gbGeneralMiscellaneous.Controls.Add(Me.chkNoDisplayFanartSmall)
        Me.gbGeneralMiscellaneous.Controls.Add(Me.chkPosterGlassOverlay)
        Me.gbGeneralMiscellaneous.Controls.Add(Me.chkSpecialDateAdd)
        Me.gbGeneralMiscellaneous.Controls.Add(Me.chkShowGenresText)
        Me.gbGeneralMiscellaneous.Controls.Add(Me.chkSourceFromFolder)
        Me.gbGeneralMiscellaneous.Controls.Add(Me.chkNoDisplayFanart)
        Me.gbGeneralMiscellaneous.Controls.Add(Me.chkInfoPanelAnim)
        Me.gbGeneralMiscellaneous.Controls.Add(Me.chkNoDisplayPoster)
        Me.gbGeneralMiscellaneous.Controls.Add(Me.chkShowDims)
        Me.gbGeneralMiscellaneous.Controls.Add(Me.chkUpdates)
        Me.gbGeneralMiscellaneous.Controls.Add(Me.chkOverwriteNfo)
        Me.gbGeneralMiscellaneous.Controls.Add(Me.Label5)
        Me.gbGeneralMiscellaneous.Controls.Add(Me.chkLogErrors)
        Me.gbGeneralMiscellaneous.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.gbGeneralMiscellaneous.Location = New System.Drawing.Point(210, 3)
        Me.gbGeneralMiscellaneous.Name = "gbGeneralMiscellaneous"
        Me.gbGeneralMiscellaneous.Size = New System.Drawing.Size(417, 344)
        Me.gbGeneralMiscellaneous.TabIndex = 1
        Me.gbGeneralMiscellaneous.TabStop = False
        Me.gbGeneralMiscellaneous.Text = "Miscellaneous"
        '
        'chkNoDisplayFanartSmall
        '
        Me.chkNoDisplayFanartSmall.AutoSize = True
        Me.chkNoDisplayFanartSmall.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkNoDisplayFanartSmall.Location = New System.Drawing.Point(10, 144)
        Me.chkNoDisplayFanartSmall.Name = "chkNoDisplayFanartSmall"
        Me.chkNoDisplayFanartSmall.Size = New System.Drawing.Size(169, 17)
        Me.chkNoDisplayFanartSmall.TabIndex = 12
        Me.chkNoDisplayFanartSmall.Text = "Do Not Display Small Fanart"
        Me.chkNoDisplayFanartSmall.UseVisualStyleBackColor = True
        '
        'chkPosterGlassOverlay
        '
        Me.chkPosterGlassOverlay.AutoSize = True
        Me.chkPosterGlassOverlay.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkPosterGlassOverlay.Location = New System.Drawing.Point(10, 194)
        Me.chkPosterGlassOverlay.Name = "chkPosterGlassOverlay"
        Me.chkPosterGlassOverlay.Size = New System.Drawing.Size(167, 17)
        Me.chkPosterGlassOverlay.TabIndex = 11
        Me.chkPosterGlassOverlay.Text = "Enable Poster Glass Overlay"
        Me.chkPosterGlassOverlay.UseVisualStyleBackColor = True
        '
        'chkSpecialDateAdd
        '
        Me.chkSpecialDateAdd.AutoSize = True
        Me.chkSpecialDateAdd.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSpecialDateAdd.Location = New System.Drawing.Point(10, 228)
        Me.chkSpecialDateAdd.Name = "chkSpecialDateAdd"
        Me.chkSpecialDateAdd.Size = New System.Drawing.Size(196, 17)
        Me.chkSpecialDateAdd.TabIndex = 10
        Me.chkSpecialDateAdd.Text = "Use file creation date of videofile"
        Me.chkSpecialDateAdd.UseVisualStyleBackColor = True
        '
        'chkShowGenresText
        '
        Me.chkShowGenresText.AutoSize = True
        Me.chkShowGenresText.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkShowGenresText.Location = New System.Drawing.Point(10, 211)
        Me.chkShowGenresText.Name = "chkShowGenresText"
        Me.chkShowGenresText.Size = New System.Drawing.Size(166, 17)
        Me.chkShowGenresText.TabIndex = 9
        Me.chkShowGenresText.Text = "Allways Display Genres Text"
        Me.chkShowGenresText.UseVisualStyleBackColor = True
        '
        'chkSourceFromFolder
        '
        Me.chkSourceFromFolder.AutoSize = True
        Me.chkSourceFromFolder.CheckAlign = System.Drawing.ContentAlignment.TopLeft
        Me.chkSourceFromFolder.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSourceFromFolder.Location = New System.Drawing.Point(10, 110)
        Me.chkSourceFromFolder.Name = "chkSourceFromFolder"
        Me.chkSourceFromFolder.Size = New System.Drawing.Size(243, 17)
        Me.chkSourceFromFolder.TabIndex = 5
        Me.chkSourceFromFolder.Text = "Include Folder Name in Source Type Check"
        Me.chkSourceFromFolder.UseVisualStyleBackColor = True
        '
        'chkNoDisplayFanart
        '
        Me.chkNoDisplayFanart.AutoSize = True
        Me.chkNoDisplayFanart.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkNoDisplayFanart.Location = New System.Drawing.Point(10, 160)
        Me.chkNoDisplayFanart.Name = "chkNoDisplayFanart"
        Me.chkNoDisplayFanart.Size = New System.Drawing.Size(139, 17)
        Me.chkNoDisplayFanart.TabIndex = 7
        Me.chkNoDisplayFanart.Text = "Do Not Display Fanart"
        Me.chkNoDisplayFanart.UseVisualStyleBackColor = True
        '
        'chkInfoPanelAnim
        '
        Me.chkInfoPanelAnim.AutoSize = True
        Me.chkInfoPanelAnim.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkInfoPanelAnim.Location = New System.Drawing.Point(10, 94)
        Me.chkInfoPanelAnim.Name = "chkInfoPanelAnim"
        Me.chkInfoPanelAnim.Size = New System.Drawing.Size(148, 17)
        Me.chkInfoPanelAnim.TabIndex = 4
        Me.chkInfoPanelAnim.Text = "Enable Panel Animation"
        Me.chkInfoPanelAnim.UseVisualStyleBackColor = True
        '
        'chkNoDisplayPoster
        '
        Me.chkNoDisplayPoster.AutoSize = True
        Me.chkNoDisplayPoster.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkNoDisplayPoster.Location = New System.Drawing.Point(10, 127)
        Me.chkNoDisplayPoster.Name = "chkNoDisplayPoster"
        Me.chkNoDisplayPoster.Size = New System.Drawing.Size(138, 17)
        Me.chkNoDisplayPoster.TabIndex = 6
        Me.chkNoDisplayPoster.Text = "Do Not Display Poster"
        Me.chkNoDisplayPoster.UseVisualStyleBackColor = True
        '
        'chkShowDims
        '
        Me.chkShowDims.AutoSize = True
        Me.chkShowDims.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkShowDims.Location = New System.Drawing.Point(10, 177)
        Me.chkShowDims.Name = "chkShowDims"
        Me.chkShowDims.Size = New System.Drawing.Size(160, 17)
        Me.chkShowDims.TabIndex = 8
        Me.chkShowDims.Text = "Display Image Dimensions"
        Me.chkShowDims.UseVisualStyleBackColor = True
        '
        'chkUpdates
        '
        Me.chkUpdates.AutoSize = True
        Me.chkUpdates.Enabled = False
        Me.chkUpdates.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkUpdates.Location = New System.Drawing.Point(10, 20)
        Me.chkUpdates.Name = "chkUpdates"
        Me.chkUpdates.Size = New System.Drawing.Size(121, 17)
        Me.chkUpdates.TabIndex = 0
        Me.chkUpdates.Text = "Check for Updates"
        Me.chkUpdates.UseVisualStyleBackColor = True
        Me.chkUpdates.Visible = False
        '
        'chkOverwriteNfo
        '
        Me.chkOverwriteNfo.AutoSize = True
        Me.chkOverwriteNfo.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkOverwriteNfo.Location = New System.Drawing.Point(10, 54)
        Me.chkOverwriteNfo.Name = "chkOverwriteNfo"
        Me.chkOverwriteNfo.Size = New System.Drawing.Size(191, 17)
        Me.chkOverwriteNfo.TabIndex = 2
        Me.chkOverwriteNfo.Text = "Overwrite Non-conforming nfos"
        Me.chkOverwriteNfo.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(20, 68)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(165, 24)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "(If unchecked, non-conforming nfos will be renamed to <filename>.info)"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'chkLogErrors
        '
        Me.chkLogErrors.AutoSize = True
        Me.chkLogErrors.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkLogErrors.Location = New System.Drawing.Point(10, 37)
        Me.chkLogErrors.Name = "chkLogErrors"
        Me.chkLogErrors.Size = New System.Drawing.Size(113, 17)
        Me.chkLogErrors.TabIndex = 1
        Me.chkLogErrors.Text = "Log Errors to File"
        Me.chkLogErrors.UseVisualStyleBackColor = True
        '
        'GroupBox29
        '
        Me.GroupBox29.Controls.Add(Me.cbEpTheme)
        Me.GroupBox29.Controls.Add(Me.Label3)
        Me.GroupBox29.Controls.Add(Me.cbTVShowTheme)
        Me.GroupBox29.Controls.Add(Me.Label1)
        Me.GroupBox29.Controls.Add(Me.cbMovieTheme)
        Me.GroupBox29.Controls.Add(Me.Label35)
        Me.GroupBox29.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.GroupBox29.Location = New System.Drawing.Point(8, 61)
        Me.GroupBox29.Name = "GroupBox29"
        Me.GroupBox29.Size = New System.Drawing.Size(179, 166)
        Me.GroupBox29.TabIndex = 2
        Me.GroupBox29.TabStop = False
        Me.GroupBox29.Text = "Themes"
        '
        'cbEpTheme
        '
        Me.cbEpTheme.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbEpTheme.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.cbEpTheme.FormattingEnabled = True
        Me.cbEpTheme.Location = New System.Drawing.Point(9, 129)
        Me.cbEpTheme.Name = "cbEpTheme"
        Me.cbEpTheme.Size = New System.Drawing.Size(162, 21)
        Me.cbEpTheme.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(7, 114)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Episode Theme:"
        '
        'cbTVShowTheme
        '
        Me.cbTVShowTheme.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTVShowTheme.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.cbTVShowTheme.FormattingEnabled = True
        Me.cbTVShowTheme.Location = New System.Drawing.Point(9, 83)
        Me.cbTVShowTheme.Name = "cbTVShowTheme"
        Me.cbTVShowTheme.Size = New System.Drawing.Size(162, 21)
        Me.cbTVShowTheme.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(7, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "TV Show Theme:"
        '
        'cbMovieTheme
        '
        Me.cbMovieTheme.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbMovieTheme.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.cbMovieTheme.FormattingEnabled = True
        Me.cbMovieTheme.Location = New System.Drawing.Point(9, 38)
        Me.cbMovieTheme.Name = "cbMovieTheme"
        Me.cbMovieTheme.Size = New System.Drawing.Size(162, 21)
        Me.cbMovieTheme.TabIndex = 1
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.Location = New System.Drawing.Point(7, 23)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(77, 13)
        Me.Label35.TabIndex = 0
        Me.Label35.Text = "Movie Theme:"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.Location = New System.Drawing.Point(6, 18)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(109, 13)
        Me.Label32.TabIndex = 0
        Me.Label32.Text = "Interface Language:"
        '
        'cbIntLang
        '
        Me.cbIntLang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbIntLang.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.cbIntLang.FormattingEnabled = True
        Me.cbIntLang.Location = New System.Drawing.Point(9, 34)
        Me.cbIntLang.Name = "cbIntLang"
        Me.cbIntLang.Size = New System.Drawing.Size(137, 21)
        Me.cbIntLang.TabIndex = 1
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.tcCleaner)
        Me.GroupBox3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(401, 6)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(208, 385)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Clean Files"
        '
        'tcCleaner
        '
        Me.tcCleaner.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.tcCleaner.Controls.Add(Me.tpStandard)
        Me.tcCleaner.Controls.Add(Me.tpExpert)
        Me.tcCleaner.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.tcCleaner.Location = New System.Drawing.Point(6, 19)
        Me.tcCleaner.Name = "tcCleaner"
        Me.tcCleaner.SelectedIndex = 0
        Me.tcCleaner.Size = New System.Drawing.Size(196, 363)
        Me.tcCleaner.TabIndex = 0
        '
        'tpStandard
        '
        Me.tpStandard.BackColor = System.Drawing.Color.White
        Me.tpStandard.Controls.Add(Me.chkCleanFolderJPG)
        Me.tpStandard.Controls.Add(Me.chkCleanExtrathumbs)
        Me.tpStandard.Controls.Add(Me.chkCleanMovieTBN)
        Me.tpStandard.Controls.Add(Me.chkCleanMovieNameJPG)
        Me.tpStandard.Controls.Add(Me.chkCleanMovieTBNb)
        Me.tpStandard.Controls.Add(Me.chkCleanMovieJPG)
        Me.tpStandard.Controls.Add(Me.chkCleanFanartJPG)
        Me.tpStandard.Controls.Add(Me.chkCleanPosterJPG)
        Me.tpStandard.Controls.Add(Me.chkCleanMovieFanartJPG)
        Me.tpStandard.Controls.Add(Me.chkCleanPosterTBN)
        Me.tpStandard.Controls.Add(Me.chkCleanMovieNFO)
        Me.tpStandard.Controls.Add(Me.chkCleanDotFanartJPG)
        Me.tpStandard.Controls.Add(Me.chkCleanMovieNFOb)
        Me.tpStandard.Location = New System.Drawing.Point(4, 25)
        Me.tpStandard.Name = "tpStandard"
        Me.tpStandard.Padding = New System.Windows.Forms.Padding(3)
        Me.tpStandard.Size = New System.Drawing.Size(188, 334)
        Me.tpStandard.TabIndex = 0
        Me.tpStandard.Text = "Standard"
        Me.tpStandard.UseVisualStyleBackColor = True
        '
        'chkCleanFolderJPG
        '
        Me.chkCleanFolderJPG.AutoSize = True
        Me.chkCleanFolderJPG.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkCleanFolderJPG.Location = New System.Drawing.Point(7, 10)
        Me.chkCleanFolderJPG.Name = "chkCleanFolderJPG"
        Me.chkCleanFolderJPG.Size = New System.Drawing.Size(81, 17)
        Me.chkCleanFolderJPG.TabIndex = 0
        Me.chkCleanFolderJPG.Text = "/folder.jpg"
        Me.chkCleanFolderJPG.UseVisualStyleBackColor = True
        '
        'chkCleanExtrathumbs
        '
        Me.chkCleanExtrathumbs.AutoSize = True
        Me.chkCleanExtrathumbs.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkCleanExtrathumbs.Location = New System.Drawing.Point(7, 238)
        Me.chkCleanExtrathumbs.Name = "chkCleanExtrathumbs"
        Me.chkCleanExtrathumbs.Size = New System.Drawing.Size(98, 17)
        Me.chkCleanExtrathumbs.TabIndex = 12
        Me.chkCleanExtrathumbs.Text = "/extrathumbs/"
        Me.chkCleanExtrathumbs.UseVisualStyleBackColor = True
        '
        'chkCleanMovieTBN
        '
        Me.chkCleanMovieTBN.AutoSize = True
        Me.chkCleanMovieTBN.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkCleanMovieTBN.Location = New System.Drawing.Point(7, 29)
        Me.chkCleanMovieTBN.Name = "chkCleanMovieTBN"
        Me.chkCleanMovieTBN.Size = New System.Drawing.Size(81, 17)
        Me.chkCleanMovieTBN.TabIndex = 1
        Me.chkCleanMovieTBN.Text = "/movie.tbn"
        Me.chkCleanMovieTBN.UseVisualStyleBackColor = True
        '
        'chkCleanMovieNameJPG
        '
        Me.chkCleanMovieNameJPG.AutoSize = True
        Me.chkCleanMovieNameJPG.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkCleanMovieNameJPG.Location = New System.Drawing.Point(7, 124)
        Me.chkCleanMovieNameJPG.Name = "chkCleanMovieNameJPG"
        Me.chkCleanMovieNameJPG.Size = New System.Drawing.Size(96, 17)
        Me.chkCleanMovieNameJPG.TabIndex = 6
        Me.chkCleanMovieNameJPG.Text = "/<movie>.jpg"
        Me.chkCleanMovieNameJPG.UseVisualStyleBackColor = True
        '
        'chkCleanMovieTBNb
        '
        Me.chkCleanMovieTBNb.AutoSize = True
        Me.chkCleanMovieTBNb.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkCleanMovieTBNb.Location = New System.Drawing.Point(7, 48)
        Me.chkCleanMovieTBNb.Name = "chkCleanMovieTBNb"
        Me.chkCleanMovieTBNb.Size = New System.Drawing.Size(97, 17)
        Me.chkCleanMovieTBNb.TabIndex = 2
        Me.chkCleanMovieTBNb.Text = "/<movie>.tbn"
        Me.chkCleanMovieTBNb.UseVisualStyleBackColor = True
        '
        'chkCleanMovieJPG
        '
        Me.chkCleanMovieJPG.AutoSize = True
        Me.chkCleanMovieJPG.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkCleanMovieJPG.Location = New System.Drawing.Point(7, 105)
        Me.chkCleanMovieJPG.Name = "chkCleanMovieJPG"
        Me.chkCleanMovieJPG.Size = New System.Drawing.Size(80, 17)
        Me.chkCleanMovieJPG.TabIndex = 5
        Me.chkCleanMovieJPG.Text = "/movie.jpg"
        Me.chkCleanMovieJPG.UseVisualStyleBackColor = True
        '
        'chkCleanFanartJPG
        '
        Me.chkCleanFanartJPG.AutoSize = True
        Me.chkCleanFanartJPG.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkCleanFanartJPG.Location = New System.Drawing.Point(7, 143)
        Me.chkCleanFanartJPG.Name = "chkCleanFanartJPG"
        Me.chkCleanFanartJPG.Size = New System.Drawing.Size(81, 17)
        Me.chkCleanFanartJPG.TabIndex = 7
        Me.chkCleanFanartJPG.Text = "/fanart.jpg"
        Me.chkCleanFanartJPG.UseVisualStyleBackColor = True
        '
        'chkCleanPosterJPG
        '
        Me.chkCleanPosterJPG.AutoSize = True
        Me.chkCleanPosterJPG.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkCleanPosterJPG.Location = New System.Drawing.Point(7, 86)
        Me.chkCleanPosterJPG.Name = "chkCleanPosterJPG"
        Me.chkCleanPosterJPG.Size = New System.Drawing.Size(83, 17)
        Me.chkCleanPosterJPG.TabIndex = 4
        Me.chkCleanPosterJPG.Text = "/poster.jpg"
        Me.chkCleanPosterJPG.UseVisualStyleBackColor = True
        '
        'chkCleanMovieFanartJPG
        '
        Me.chkCleanMovieFanartJPG.AutoSize = True
        Me.chkCleanMovieFanartJPG.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkCleanMovieFanartJPG.Location = New System.Drawing.Point(7, 162)
        Me.chkCleanMovieFanartJPG.Name = "chkCleanMovieFanartJPG"
        Me.chkCleanMovieFanartJPG.Size = New System.Drawing.Size(131, 17)
        Me.chkCleanMovieFanartJPG.TabIndex = 8
        Me.chkCleanMovieFanartJPG.Text = "/<movie>-fanart.jpg"
        Me.chkCleanMovieFanartJPG.UseVisualStyleBackColor = True
        '
        'chkCleanPosterTBN
        '
        Me.chkCleanPosterTBN.AutoSize = True
        Me.chkCleanPosterTBN.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkCleanPosterTBN.Location = New System.Drawing.Point(7, 67)
        Me.chkCleanPosterTBN.Name = "chkCleanPosterTBN"
        Me.chkCleanPosterTBN.Size = New System.Drawing.Size(84, 17)
        Me.chkCleanPosterTBN.TabIndex = 3
        Me.chkCleanPosterTBN.Text = "/poster.tbn"
        Me.chkCleanPosterTBN.UseVisualStyleBackColor = True
        '
        'chkCleanMovieNFO
        '
        Me.chkCleanMovieNFO.AutoSize = True
        Me.chkCleanMovieNFO.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkCleanMovieNFO.Location = New System.Drawing.Point(7, 200)
        Me.chkCleanMovieNFO.Name = "chkCleanMovieNFO"
        Me.chkCleanMovieNFO.Size = New System.Drawing.Size(81, 17)
        Me.chkCleanMovieNFO.TabIndex = 10
        Me.chkCleanMovieNFO.Text = "/movie.nfo"
        Me.chkCleanMovieNFO.UseVisualStyleBackColor = True
        '
        'chkCleanDotFanartJPG
        '
        Me.chkCleanDotFanartJPG.AutoSize = True
        Me.chkCleanDotFanartJPG.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkCleanDotFanartJPG.Location = New System.Drawing.Point(7, 181)
        Me.chkCleanDotFanartJPG.Name = "chkCleanDotFanartJPG"
        Me.chkCleanDotFanartJPG.Size = New System.Drawing.Size(130, 17)
        Me.chkCleanDotFanartJPG.TabIndex = 9
        Me.chkCleanDotFanartJPG.Text = "/<movie>.fanart.jpg"
        Me.chkCleanDotFanartJPG.UseVisualStyleBackColor = True
        '
        'chkCleanMovieNFOb
        '
        Me.chkCleanMovieNFOb.AutoSize = True
        Me.chkCleanMovieNFOb.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkCleanMovieNFOb.Location = New System.Drawing.Point(7, 219)
        Me.chkCleanMovieNFOb.Name = "chkCleanMovieNFOb"
        Me.chkCleanMovieNFOb.Size = New System.Drawing.Size(97, 17)
        Me.chkCleanMovieNFOb.TabIndex = 11
        Me.chkCleanMovieNFOb.Text = "/<movie>.nfo"
        Me.chkCleanMovieNFOb.UseVisualStyleBackColor = True
        '
        'tpExpert
        '
        Me.tpExpert.BackColor = System.Drawing.Color.White
        Me.tpExpert.Controls.Add(Me.chkWhitelistVideo)
        Me.tpExpert.Controls.Add(Me.Label27)
        Me.tpExpert.Controls.Add(Me.btnRemoveWhitelist)
        Me.tpExpert.Controls.Add(Me.btnAddWhitelist)
        Me.tpExpert.Controls.Add(Me.txtWhitelist)
        Me.tpExpert.Controls.Add(Me.lstWhitelist)
        Me.tpExpert.Controls.Add(Me.Label25)
        Me.tpExpert.Location = New System.Drawing.Point(4, 25)
        Me.tpExpert.Name = "tpExpert"
        Me.tpExpert.Padding = New System.Windows.Forms.Padding(3)
        Me.tpExpert.Size = New System.Drawing.Size(188, 334)
        Me.tpExpert.TabIndex = 1
        Me.tpExpert.Text = "Expert"
        Me.tpExpert.UseVisualStyleBackColor = True
        '
        'chkWhitelistVideo
        '
        Me.chkWhitelistVideo.AutoSize = True
        Me.chkWhitelistVideo.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkWhitelistVideo.Location = New System.Drawing.Point(4, 85)
        Me.chkWhitelistVideo.Name = "chkWhitelistVideo"
        Me.chkWhitelistVideo.Size = New System.Drawing.Size(163, 17)
        Me.chkWhitelistVideo.TabIndex = 1
        Me.chkWhitelistVideo.Text = "Whitelist Video Extensions"
        Me.chkWhitelistVideo.UseVisualStyleBackColor = True
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(19, 107)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(127, 13)
        Me.Label27.TabIndex = 2
        Me.Label27.Text = "Whitelisted Extensions:"
        '
        'btnRemoveWhitelist
        '
        Me.btnRemoveWhitelist.Image = CType(resources.GetObject("btnRemoveWhitelist.Image"), System.Drawing.Image)
        Me.btnRemoveWhitelist.Location = New System.Drawing.Point(134, 251)
        Me.btnRemoveWhitelist.Name = "btnRemoveWhitelist"
        Me.btnRemoveWhitelist.Size = New System.Drawing.Size(23, 23)
        Me.btnRemoveWhitelist.TabIndex = 6
        Me.btnRemoveWhitelist.UseVisualStyleBackColor = True
        '
        'btnAddWhitelist
        '
        Me.btnAddWhitelist.Image = CType(resources.GetObject("btnAddWhitelist.Image"), System.Drawing.Image)
        Me.btnAddWhitelist.Location = New System.Drawing.Point(82, 251)
        Me.btnAddWhitelist.Name = "btnAddWhitelist"
        Me.btnAddWhitelist.Size = New System.Drawing.Size(23, 23)
        Me.btnAddWhitelist.TabIndex = 5
        Me.btnAddWhitelist.UseVisualStyleBackColor = True
        '
        'txtWhitelist
        '
        Me.txtWhitelist.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtWhitelist.Location = New System.Drawing.Point(20, 252)
        Me.txtWhitelist.Name = "txtWhitelist"
        Me.txtWhitelist.Size = New System.Drawing.Size(61, 22)
        Me.txtWhitelist.TabIndex = 4
        '
        'lstWhitelist
        '
        Me.lstWhitelist.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lstWhitelist.FormattingEnabled = True
        Me.lstWhitelist.Location = New System.Drawing.Point(19, 126)
        Me.lstWhitelist.Name = "lstWhitelist"
        Me.lstWhitelist.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.lstWhitelist.Size = New System.Drawing.Size(138, 108)
        Me.lstWhitelist.TabIndex = 3
        '
        'Label25
        '
        Me.Label25.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.Red
        Me.Label25.Location = New System.Drawing.Point(12, 10)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(155, 68)
        Me.Label25.TabIndex = 0
        Me.Label25.Text = "WARNING: Using the Expert Mode Cleaner could potentially delete wanted files. Tak" & _
    "e care when using this tool."
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'gbMoviesMiscellaneous
        '
        Me.gbMoviesMiscellaneous.Controls.Add(Me.chkClickScrape)
        Me.gbMoviesMiscellaneous.Controls.Add(Me.chkAskCheckboxScrape)
        Me.gbMoviesMiscellaneous.Controls.Add(Me.chkMarkNew)
        Me.gbMoviesMiscellaneous.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.gbMoviesMiscellaneous.Location = New System.Drawing.Point(6, 7)
        Me.gbMoviesMiscellaneous.Name = "gbMoviesMiscellaneous"
        Me.gbMoviesMiscellaneous.Size = New System.Drawing.Size(219, 93)
        Me.gbMoviesMiscellaneous.TabIndex = 1
        Me.gbMoviesMiscellaneous.TabStop = False
        Me.gbMoviesMiscellaneous.Text = "Miscellaneous"
        '
        'chkClickScrape
        '
        Me.chkClickScrape.AutoSize = True
        Me.chkClickScrape.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.chkClickScrape.Location = New System.Drawing.Point(12, 36)
        Me.chkClickScrape.Name = "chkClickScrape"
        Me.chkClickScrape.Size = New System.Drawing.Size(125, 17)
        Me.chkClickScrape.TabIndex = 65
        Me.chkClickScrape.Text = "Enable Click Scrape"
        Me.chkClickScrape.UseVisualStyleBackColor = True
        '
        'chkAskCheckboxScrape
        '
        Me.chkAskCheckboxScrape.AutoSize = True
        Me.chkAskCheckboxScrape.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.chkAskCheckboxScrape.Location = New System.Drawing.Point(25, 56)
        Me.chkAskCheckboxScrape.Name = "chkAskCheckboxScrape"
        Me.chkAskCheckboxScrape.Size = New System.Drawing.Size(127, 17)
        Me.chkAskCheckboxScrape.TabIndex = 64
        Me.chkAskCheckboxScrape.Text = "Ask On Click Scrape"
        Me.chkAskCheckboxScrape.UseVisualStyleBackColor = True
        '
        'chkMarkNew
        '
        Me.chkMarkNew.AutoSize = True
        Me.chkMarkNew.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkMarkNew.Location = New System.Drawing.Point(12, 14)
        Me.chkMarkNew.Name = "chkMarkNew"
        Me.chkMarkNew.Size = New System.Drawing.Size(117, 17)
        Me.chkMarkNew.TabIndex = 0
        Me.chkMarkNew.Text = "Mark New Movies"
        Me.chkMarkNew.UseVisualStyleBackColor = True
        '
        'lbGenre
        '
        Me.lbGenre.CheckOnClick = True
        Me.lbGenre.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lbGenre.FormattingEnabled = True
        Me.lbGenre.IntegralHeight = False
        Me.lbGenre.Location = New System.Drawing.Point(10, 18)
        Me.lbGenre.Name = "lbGenre"
        Me.lbGenre.Size = New System.Drawing.Size(157, 124)
        Me.lbGenre.Sorted = True
        Me.lbGenre.TabIndex = 0
        '
        'gbMoviesMediaList
        '
        Me.gbMoviesMediaList.Controls.Add(Me.chkMovieWatchedCol)
        Me.gbMoviesMediaList.Controls.Add(Me.txtCheckTitleTol)
        Me.gbMoviesMediaList.Controls.Add(Me.Label30)
        Me.gbMoviesMediaList.Controls.Add(Me.chkCheckTitles)
        Me.gbMoviesMediaList.Controls.Add(Me.gbMoviesSortToken)
        Me.gbMoviesMediaList.Controls.Add(Me.chkDisplayYear)
        Me.gbMoviesMediaList.Controls.Add(Me.chkMovieExtraCol)
        Me.gbMoviesMediaList.Controls.Add(Me.chkMovieSubCol)
        Me.gbMoviesMediaList.Controls.Add(Me.chkMovieTrailerCol)
        Me.gbMoviesMediaList.Controls.Add(Me.chkMovieInfoCol)
        Me.gbMoviesMediaList.Controls.Add(Me.chkMovieFanartCol)
        Me.gbMoviesMediaList.Controls.Add(Me.chkMoviePosterCol)
        Me.gbMoviesMediaList.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.gbMoviesMediaList.Location = New System.Drawing.Point(7, 106)
        Me.gbMoviesMediaList.Name = "gbMoviesMediaList"
        Me.gbMoviesMediaList.Size = New System.Drawing.Size(218, 297)
        Me.gbMoviesMediaList.TabIndex = 4
        Me.gbMoviesMediaList.TabStop = False
        Me.gbMoviesMediaList.Text = "Media List Options"
        '
        'chkMovieWatchedCol
        '
        Me.chkMovieWatchedCol.AutoSize = True
        Me.chkMovieWatchedCol.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkMovieWatchedCol.Location = New System.Drawing.Point(9, 274)
        Me.chkMovieWatchedCol.Name = "chkMovieWatchedCol"
        Me.chkMovieWatchedCol.Size = New System.Drawing.Size(142, 17)
        Me.chkMovieWatchedCol.TabIndex = 75
        Me.chkMovieWatchedCol.Text = "Hide Watched Column"
        Me.chkMovieWatchedCol.UseVisualStyleBackColor = True
        '
        'txtCheckTitleTol
        '
        Me.txtCheckTitleTol.Enabled = False
        Me.txtCheckTitleTol.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCheckTitleTol.Location = New System.Drawing.Point(142, 50)
        Me.txtCheckTitleTol.Name = "txtCheckTitleTol"
        Me.txtCheckTitleTol.Size = New System.Drawing.Size(61, 22)
        Me.txtCheckTitleTol.TabIndex = 74
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(27, 54)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(111, 13)
        Me.Label30.TabIndex = 73
        Me.Label30.Text = "Mismatch Tolerance:"
        Me.Label30.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'chkCheckTitles
        '
        Me.chkCheckTitles.AutoSize = True
        Me.chkCheckTitles.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkCheckTitles.Location = New System.Drawing.Point(8, 35)
        Me.chkCheckTitles.Name = "chkCheckTitles"
        Me.chkCheckTitles.Size = New System.Drawing.Size(178, 17)
        Me.chkCheckTitles.TabIndex = 72
        Me.chkCheckTitles.Text = "Check Title Match Confidence"
        Me.chkCheckTitles.UseVisualStyleBackColor = True
        '
        'gbMoviesSortToken
        '
        Me.gbMoviesSortToken.Controls.Add(Me.btnRemoveToken)
        Me.gbMoviesSortToken.Controls.Add(Me.btnAddToken)
        Me.gbMoviesSortToken.Controls.Add(Me.txtSortToken)
        Me.gbMoviesSortToken.Controls.Add(Me.lstSortTokens)
        Me.gbMoviesSortToken.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.gbMoviesSortToken.Location = New System.Drawing.Point(9, 73)
        Me.gbMoviesSortToken.Name = "gbMoviesSortToken"
        Me.gbMoviesSortToken.Size = New System.Drawing.Size(200, 102)
        Me.gbMoviesSortToken.TabIndex = 71
        Me.gbMoviesSortToken.TabStop = False
        Me.gbMoviesSortToken.Text = "Sort Tokens to Ignore"
        '
        'btnRemoveToken
        '
        Me.btnRemoveToken.Image = CType(resources.GetObject("btnRemoveToken.Image"), System.Drawing.Image)
        Me.btnRemoveToken.Location = New System.Drawing.Point(168, 72)
        Me.btnRemoveToken.Name = "btnRemoveToken"
        Me.btnRemoveToken.Size = New System.Drawing.Size(23, 23)
        Me.btnRemoveToken.TabIndex = 3
        Me.btnRemoveToken.UseVisualStyleBackColor = True
        '
        'btnAddToken
        '
        Me.btnAddToken.Image = CType(resources.GetObject("btnAddToken.Image"), System.Drawing.Image)
        Me.btnAddToken.Location = New System.Drawing.Point(72, 72)
        Me.btnAddToken.Name = "btnAddToken"
        Me.btnAddToken.Size = New System.Drawing.Size(23, 23)
        Me.btnAddToken.TabIndex = 2
        Me.btnAddToken.UseVisualStyleBackColor = True
        '
        'txtSortToken
        '
        Me.txtSortToken.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSortToken.Location = New System.Drawing.Point(10, 73)
        Me.txtSortToken.Name = "txtSortToken"
        Me.txtSortToken.Size = New System.Drawing.Size(61, 22)
        Me.txtSortToken.TabIndex = 1
        '
        'lstSortTokens
        '
        Me.lstSortTokens.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lstSortTokens.FormattingEnabled = True
        Me.lstSortTokens.Location = New System.Drawing.Point(10, 15)
        Me.lstSortTokens.Name = "lstSortTokens"
        Me.lstSortTokens.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.lstSortTokens.Size = New System.Drawing.Size(180, 43)
        Me.lstSortTokens.Sorted = True
        Me.lstSortTokens.TabIndex = 0
        '
        'chkDisplayYear
        '
        Me.chkDisplayYear.AutoSize = True
        Me.chkDisplayYear.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkDisplayYear.Location = New System.Drawing.Point(8, 19)
        Me.chkDisplayYear.Name = "chkDisplayYear"
        Me.chkDisplayYear.Size = New System.Drawing.Size(144, 17)
        Me.chkDisplayYear.TabIndex = 70
        Me.chkDisplayYear.Text = "Display Year in List Title"
        Me.chkDisplayYear.UseVisualStyleBackColor = True
        '
        'chkMovieExtraCol
        '
        Me.chkMovieExtraCol.AutoSize = True
        Me.chkMovieExtraCol.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkMovieExtraCol.Location = New System.Drawing.Point(9, 258)
        Me.chkMovieExtraCol.Name = "chkMovieExtraCol"
        Me.chkMovieExtraCol.Size = New System.Drawing.Size(155, 17)
        Me.chkMovieExtraCol.TabIndex = 5
        Me.chkMovieExtraCol.Text = "Hide Extrathumb Column"
        Me.chkMovieExtraCol.UseVisualStyleBackColor = True
        '
        'chkMovieSubCol
        '
        Me.chkMovieSubCol.AutoSize = True
        Me.chkMovieSubCol.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkMovieSubCol.Location = New System.Drawing.Point(9, 242)
        Me.chkMovieSubCol.Name = "chkMovieSubCol"
        Me.chkMovieSubCol.Size = New System.Drawing.Size(116, 17)
        Me.chkMovieSubCol.TabIndex = 4
        Me.chkMovieSubCol.Text = "Hide Sub Column"
        Me.chkMovieSubCol.UseVisualStyleBackColor = True
        '
        'chkMovieTrailerCol
        '
        Me.chkMovieTrailerCol.AutoSize = True
        Me.chkMovieTrailerCol.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkMovieTrailerCol.Location = New System.Drawing.Point(9, 226)
        Me.chkMovieTrailerCol.Name = "chkMovieTrailerCol"
        Me.chkMovieTrailerCol.Size = New System.Drawing.Size(127, 17)
        Me.chkMovieTrailerCol.TabIndex = 3
        Me.chkMovieTrailerCol.Text = "Hide Trailer Column"
        Me.chkMovieTrailerCol.UseVisualStyleBackColor = True
        '
        'chkMovieInfoCol
        '
        Me.chkMovieInfoCol.AutoSize = True
        Me.chkMovieInfoCol.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkMovieInfoCol.Location = New System.Drawing.Point(9, 210)
        Me.chkMovieInfoCol.Name = "chkMovieInfoCol"
        Me.chkMovieInfoCol.Size = New System.Drawing.Size(117, 17)
        Me.chkMovieInfoCol.TabIndex = 2
        Me.chkMovieInfoCol.Text = "Hide Info Column"
        Me.chkMovieInfoCol.UseVisualStyleBackColor = True
        '
        'chkMovieFanartCol
        '
        Me.chkMovieFanartCol.AutoSize = True
        Me.chkMovieFanartCol.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkMovieFanartCol.Location = New System.Drawing.Point(9, 194)
        Me.chkMovieFanartCol.Name = "chkMovieFanartCol"
        Me.chkMovieFanartCol.Size = New System.Drawing.Size(129, 17)
        Me.chkMovieFanartCol.TabIndex = 1
        Me.chkMovieFanartCol.Text = "Hide Fanart Column"
        Me.chkMovieFanartCol.UseVisualStyleBackColor = True
        '
        'chkMoviePosterCol
        '
        Me.chkMoviePosterCol.AutoSize = True
        Me.chkMoviePosterCol.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkMoviePosterCol.Location = New System.Drawing.Point(9, 178)
        Me.chkMoviePosterCol.Name = "chkMoviePosterCol"
        Me.chkMoviePosterCol.Size = New System.Drawing.Size(128, 17)
        Me.chkMoviePosterCol.TabIndex = 0
        Me.chkMoviePosterCol.Text = "Hide Poster Column"
        Me.chkMoviePosterCol.UseVisualStyleBackColor = True
        '
        'gbSourcesFileNaming
        '
        Me.gbSourcesFileNaming.Controls.Add(Me.btnMovieFrodo)
        Me.gbSourcesFileNaming.Controls.Add(Me.chkMovieNameMultiOnly)
        Me.gbSourcesFileNaming.Controls.Add(Me.GroupBox21)
        Me.gbSourcesFileNaming.Controls.Add(Me.GroupBox7)
        Me.gbSourcesFileNaming.Controls.Add(Me.GroupBox6)
        Me.gbSourcesFileNaming.Controls.Add(Me.GroupBox5)
        Me.gbSourcesFileNaming.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.gbSourcesFileNaming.Location = New System.Drawing.Point(243, 113)
        Me.gbSourcesFileNaming.Name = "gbSourcesFileNaming"
        Me.gbSourcesFileNaming.Size = New System.Drawing.Size(366, 207)
        Me.gbSourcesFileNaming.TabIndex = 5
        Me.gbSourcesFileNaming.TabStop = False
        Me.gbSourcesFileNaming.Text = "File Naming"
        '
        'btnMovieFrodo
        '
        Me.btnMovieFrodo.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.btnMovieFrodo.Location = New System.Drawing.Point(237, 29)
        Me.btnMovieFrodo.Name = "btnMovieFrodo"
        Me.btnMovieFrodo.Size = New System.Drawing.Size(116, 23)
        Me.btnMovieFrodo.TabIndex = 1
        Me.btnMovieFrodo.Text = "XBMC Frodo"
        Me.btnMovieFrodo.UseVisualStyleBackColor = True
        '
        'chkMovieNameMultiOnly
        '
        Me.chkMovieNameMultiOnly.CheckAlign = System.Drawing.ContentAlignment.TopLeft
        Me.chkMovieNameMultiOnly.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkMovieNameMultiOnly.Location = New System.Drawing.Point(235, 58)
        Me.chkMovieNameMultiOnly.Name = "chkMovieNameMultiOnly"
        Me.chkMovieNameMultiOnly.Size = New System.Drawing.Size(125, 43)
        Me.chkMovieNameMultiOnly.TabIndex = 2
        Me.chkMovieNameMultiOnly.Text = "Use <movie> Only for Folders with Multiple Movies"
        Me.chkMovieNameMultiOnly.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.chkMovieNameMultiOnly.UseVisualStyleBackColor = True
        '
        'GroupBox21
        '
        Me.GroupBox21.Controls.Add(Me.rbBracketTrailer)
        Me.GroupBox21.Controls.Add(Me.rbDashTrailer)
        Me.GroupBox21.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.GroupBox21.Location = New System.Drawing.Point(150, 111)
        Me.GroupBox21.Name = "GroupBox21"
        Me.GroupBox21.Size = New System.Drawing.Size(102, 59)
        Me.GroupBox21.TabIndex = 4
        Me.GroupBox21.TabStop = False
        Me.GroupBox21.Text = "Trailer"
        '
        'rbBracketTrailer
        '
        Me.rbBracketTrailer.AutoSize = True
        Me.rbBracketTrailer.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbBracketTrailer.Location = New System.Drawing.Point(5, 33)
        Me.rbBracketTrailer.Name = "rbBracketTrailer"
        Me.rbBracketTrailer.Size = New System.Drawing.Size(61, 17)
        Me.rbBracketTrailer.TabIndex = 1
        Me.rbBracketTrailer.TabStop = True
        Me.rbBracketTrailer.Text = "[trailer]"
        Me.rbBracketTrailer.UseVisualStyleBackColor = True
        '
        'rbDashTrailer
        '
        Me.rbDashTrailer.AutoSize = True
        Me.rbDashTrailer.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbDashTrailer.ForeColor = System.Drawing.SystemColors.ControlText
        Me.rbDashTrailer.Location = New System.Drawing.Point(5, 17)
        Me.rbDashTrailer.Name = "rbDashTrailer"
        Me.rbDashTrailer.Size = New System.Drawing.Size(59, 17)
        Me.rbDashTrailer.TabIndex = 0
        Me.rbDashTrailer.TabStop = True
        Me.rbDashTrailer.Text = "-trailer"
        Me.rbDashTrailer.UseVisualStyleBackColor = True
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.chkMovieNameNFOStack)
        Me.GroupBox7.Controls.Add(Me.chkMovieNameNFO)
        Me.GroupBox7.Controls.Add(Me.chkMovieNFO)
        Me.GroupBox7.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.GroupBox7.Location = New System.Drawing.Point(258, 111)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(102, 90)
        Me.GroupBox7.TabIndex = 5
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "NFO"
        '
        'chkMovieNameNFOStack
        '
        Me.chkMovieNameNFOStack.AutoSize = True
        Me.chkMovieNameNFOStack.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkMovieNameNFOStack.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkMovieNameNFOStack.Location = New System.Drawing.Point(6, 51)
        Me.chkMovieNameNFOStack.Name = "chkMovieNameNFOStack"
        Me.chkMovieNameNFOStack.Size = New System.Drawing.Size(93, 30)
        Me.chkMovieNameNFOStack.TabIndex = 2
        Me.chkMovieNameNFOStack.Text = "<movie>.nfo" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Stack)"
        Me.chkMovieNameNFOStack.UseVisualStyleBackColor = True
        '
        'chkMovieNameNFO
        '
        Me.chkMovieNameNFO.AutoSize = True
        Me.chkMovieNameNFO.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkMovieNameNFO.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkMovieNameNFO.Location = New System.Drawing.Point(6, 34)
        Me.chkMovieNameNFO.Name = "chkMovieNameNFO"
        Me.chkMovieNameNFO.Size = New System.Drawing.Size(93, 17)
        Me.chkMovieNameNFO.TabIndex = 1
        Me.chkMovieNameNFO.Text = "<movie>.nfo"
        Me.chkMovieNameNFO.UseVisualStyleBackColor = True
        '
        'chkMovieNFO
        '
        Me.chkMovieNFO.AutoSize = True
        Me.chkMovieNFO.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkMovieNFO.Location = New System.Drawing.Point(6, 18)
        Me.chkMovieNFO.Name = "chkMovieNFO"
        Me.chkMovieNFO.Size = New System.Drawing.Size(77, 17)
        Me.chkMovieNFO.TabIndex = 0
        Me.chkMovieNFO.Text = "movie.nfo"
        Me.chkMovieNFO.UseVisualStyleBackColor = True
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.chkMovieNameDotFanartJPG)
        Me.GroupBox6.Controls.Add(Me.chkMovieNameFanartJPG)
        Me.GroupBox6.Controls.Add(Me.chkFanartJPG)
        Me.GroupBox6.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.GroupBox6.Location = New System.Drawing.Point(6, 111)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(136, 81)
        Me.GroupBox6.TabIndex = 3
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Fanart"
        '
        'chkMovieNameDotFanartJPG
        '
        Me.chkMovieNameDotFanartJPG.AutoSize = True
        Me.chkMovieNameDotFanartJPG.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkMovieNameDotFanartJPG.Location = New System.Drawing.Point(6, 51)
        Me.chkMovieNameDotFanartJPG.Name = "chkMovieNameDotFanartJPG"
        Me.chkMovieNameDotFanartJPG.Size = New System.Drawing.Size(126, 17)
        Me.chkMovieNameDotFanartJPG.TabIndex = 2
        Me.chkMovieNameDotFanartJPG.Text = "<movie>.fanart.jpg"
        Me.chkMovieNameDotFanartJPG.UseVisualStyleBackColor = True
        '
        'chkMovieNameFanartJPG
        '
        Me.chkMovieNameFanartJPG.AutoSize = True
        Me.chkMovieNameFanartJPG.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkMovieNameFanartJPG.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkMovieNameFanartJPG.Location = New System.Drawing.Point(6, 35)
        Me.chkMovieNameFanartJPG.Name = "chkMovieNameFanartJPG"
        Me.chkMovieNameFanartJPG.Size = New System.Drawing.Size(127, 17)
        Me.chkMovieNameFanartJPG.TabIndex = 1
        Me.chkMovieNameFanartJPG.Text = "<movie>-fanart.jpg"
        Me.chkMovieNameFanartJPG.UseVisualStyleBackColor = True
        '
        'chkFanartJPG
        '
        Me.chkFanartJPG.AutoSize = True
        Me.chkFanartJPG.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkFanartJPG.Location = New System.Drawing.Point(6, 19)
        Me.chkFanartJPG.Name = "chkFanartJPG"
        Me.chkFanartJPG.Size = New System.Drawing.Size(77, 17)
        Me.chkFanartJPG.TabIndex = 0
        Me.chkFanartJPG.Text = "fanart.jpg"
        Me.chkFanartJPG.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.chkMovieNameDashPosterJPG)
        Me.GroupBox5.Controls.Add(Me.chkFolderJPG)
        Me.GroupBox5.Controls.Add(Me.chkPosterJPG)
        Me.GroupBox5.Controls.Add(Me.chkPosterTBN)
        Me.GroupBox5.Controls.Add(Me.chkMovieNameJPG)
        Me.GroupBox5.Controls.Add(Me.chkMovieJPG)
        Me.GroupBox5.Controls.Add(Me.chkMovieNameTBN)
        Me.GroupBox5.Controls.Add(Me.chkMovieTBN)
        Me.GroupBox5.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.GroupBox5.Location = New System.Drawing.Point(6, 17)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(221, 83)
        Me.GroupBox5.TabIndex = 0
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Posters"
        '
        'chkMovieNameDashPosterJPG
        '
        Me.chkMovieNameDashPosterJPG.AutoSize = True
        Me.chkMovieNameDashPosterJPG.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkMovieNameDashPosterJPG.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkMovieNameDashPosterJPG.Location = New System.Drawing.Point(85, 63)
        Me.chkMovieNameDashPosterJPG.Name = "chkMovieNameDashPosterJPG"
        Me.chkMovieNameDashPosterJPG.Size = New System.Drawing.Size(129, 17)
        Me.chkMovieNameDashPosterJPG.TabIndex = 7
        Me.chkMovieNameDashPosterJPG.Text = "<movie>-poster.jpg"
        Me.chkMovieNameDashPosterJPG.UseVisualStyleBackColor = True
        '
        'chkFolderJPG
        '
        Me.chkFolderJPG.AutoSize = True
        Me.chkFolderJPG.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkFolderJPG.Location = New System.Drawing.Point(6, 63)
        Me.chkFolderJPG.Name = "chkFolderJPG"
        Me.chkFolderJPG.Size = New System.Drawing.Size(77, 17)
        Me.chkFolderJPG.TabIndex = 3
        Me.chkFolderJPG.Text = "folder.jpg"
        Me.chkFolderJPG.UseVisualStyleBackColor = True
        '
        'chkPosterJPG
        '
        Me.chkPosterJPG.AutoSize = True
        Me.chkPosterJPG.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkPosterJPG.Location = New System.Drawing.Point(85, 47)
        Me.chkPosterJPG.Name = "chkPosterJPG"
        Me.chkPosterJPG.Size = New System.Drawing.Size(79, 17)
        Me.chkPosterJPG.TabIndex = 6
        Me.chkPosterJPG.Text = "poster.jpg"
        Me.chkPosterJPG.UseVisualStyleBackColor = True
        '
        'chkPosterTBN
        '
        Me.chkPosterTBN.AutoSize = True
        Me.chkPosterTBN.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkPosterTBN.Location = New System.Drawing.Point(6, 47)
        Me.chkPosterTBN.Name = "chkPosterTBN"
        Me.chkPosterTBN.Size = New System.Drawing.Size(80, 17)
        Me.chkPosterTBN.TabIndex = 2
        Me.chkPosterTBN.Text = "poster.tbn"
        Me.chkPosterTBN.UseVisualStyleBackColor = True
        '
        'chkMovieNameJPG
        '
        Me.chkMovieNameJPG.AutoSize = True
        Me.chkMovieNameJPG.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkMovieNameJPG.Location = New System.Drawing.Point(85, 31)
        Me.chkMovieNameJPG.Name = "chkMovieNameJPG"
        Me.chkMovieNameJPG.Size = New System.Drawing.Size(92, 17)
        Me.chkMovieNameJPG.TabIndex = 5
        Me.chkMovieNameJPG.Text = "<movie>.jpg"
        Me.chkMovieNameJPG.UseVisualStyleBackColor = True
        '
        'chkMovieJPG
        '
        Me.chkMovieJPG.AutoSize = True
        Me.chkMovieJPG.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkMovieJPG.Location = New System.Drawing.Point(6, 31)
        Me.chkMovieJPG.Name = "chkMovieJPG"
        Me.chkMovieJPG.Size = New System.Drawing.Size(76, 17)
        Me.chkMovieJPG.TabIndex = 1
        Me.chkMovieJPG.Text = "movie.jpg"
        Me.chkMovieJPG.UseVisualStyleBackColor = True
        '
        'chkMovieNameTBN
        '
        Me.chkMovieNameTBN.AutoSize = True
        Me.chkMovieNameTBN.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkMovieNameTBN.Location = New System.Drawing.Point(85, 15)
        Me.chkMovieNameTBN.Name = "chkMovieNameTBN"
        Me.chkMovieNameTBN.Size = New System.Drawing.Size(93, 17)
        Me.chkMovieNameTBN.TabIndex = 4
        Me.chkMovieNameTBN.Text = "<movie>.tbn"
        Me.chkMovieNameTBN.UseVisualStyleBackColor = True
        '
        'chkMovieTBN
        '
        Me.chkMovieTBN.AutoSize = True
        Me.chkMovieTBN.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkMovieTBN.Location = New System.Drawing.Point(6, 15)
        Me.chkMovieTBN.Name = "chkMovieTBN"
        Me.chkMovieTBN.Size = New System.Drawing.Size(77, 17)
        Me.chkMovieTBN.TabIndex = 0
        Me.chkMovieTBN.Text = "movie.tbn"
        Me.chkMovieTBN.UseVisualStyleBackColor = True
        '
        'lvMovies
        '
        Me.lvMovies.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colID, Me.colName, Me.colPath, Me.colRecur, Me.colFolder, Me.colSingle})
        Me.lvMovies.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lvMovies.FullRowSelect = True
        Me.lvMovies.HideSelection = False
        Me.lvMovies.Location = New System.Drawing.Point(5, 6)
        Me.lvMovies.Name = "lvMovies"
        Me.lvMovies.Size = New System.Drawing.Size(497, 105)
        Me.lvMovies.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.lvMovies.TabIndex = 0
        Me.lvMovies.UseCompatibleStateImageBehavior = False
        Me.lvMovies.View = System.Windows.Forms.View.Details
        '
        'colID
        '
        Me.colID.Width = 0
        '
        'colName
        '
        Me.colName.Text = "Name"
        Me.colName.Width = 75
        '
        'colPath
        '
        Me.colPath.Text = "Path"
        Me.colPath.Width = 134
        '
        'colRecur
        '
        Me.colRecur.Text = "Recursive"
        Me.colRecur.Width = 78
        '
        'colFolder
        '
        Me.colFolder.Text = "Use Folder Name"
        Me.colFolder.Width = 116
        '
        'colSingle
        '
        Me.colSingle.Text = "Single Video"
        Me.colSingle.Width = 90
        '
        'btnMovieRem
        '
        Me.btnMovieRem.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMovieRem.Image = CType(resources.GetObject("btnMovieRem.Image"), System.Drawing.Image)
        Me.btnMovieRem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMovieRem.Location = New System.Drawing.Point(506, 88)
        Me.btnMovieRem.Name = "btnMovieRem"
        Me.btnMovieRem.Size = New System.Drawing.Size(104, 23)
        Me.btnMovieRem.TabIndex = 3
        Me.btnMovieRem.Text = "Remove"
        Me.btnMovieRem.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnMovieRem.UseVisualStyleBackColor = True
        '
        'btnMovieAddFolder
        '
        Me.btnMovieAddFolder.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMovieAddFolder.Image = CType(resources.GetObject("btnMovieAddFolder.Image"), System.Drawing.Image)
        Me.btnMovieAddFolder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMovieAddFolder.Location = New System.Drawing.Point(506, 6)
        Me.btnMovieAddFolder.Name = "btnMovieAddFolder"
        Me.btnMovieAddFolder.Size = New System.Drawing.Size(104, 23)
        Me.btnMovieAddFolder.TabIndex = 1
        Me.btnMovieAddFolder.Text = "Add Source"
        Me.btnMovieAddFolder.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnMovieAddFolder.UseVisualStyleBackColor = True
        '
        'gbImagesPoster
        '
        Me.gbImagesPoster.Controls.Add(Me.chkPosterOnly)
        Me.gbImagesPoster.Controls.Add(Me.txtPosterWidth)
        Me.gbImagesPoster.Controls.Add(Me.txtPosterHeight)
        Me.gbImagesPoster.Controls.Add(Me.lblPosterQual)
        Me.gbImagesPoster.Controls.Add(Me.tbPosterQual)
        Me.gbImagesPoster.Controls.Add(Me.Label24)
        Me.gbImagesPoster.Controls.Add(Me.Label11)
        Me.gbImagesPoster.Controls.Add(Me.Label12)
        Me.gbImagesPoster.Controls.Add(Me.chkResizePoster)
        Me.gbImagesPoster.Controls.Add(Me.lblPosterSize)
        Me.gbImagesPoster.Controls.Add(Me.cbPosterSize)
        Me.gbImagesPoster.Controls.Add(Me.chkOverwritePoster)
        Me.gbImagesPoster.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.gbImagesPoster.Location = New System.Drawing.Point(190, 3)
        Me.gbImagesPoster.Name = "gbImagesPoster"
        Me.gbImagesPoster.Size = New System.Drawing.Size(218, 170)
        Me.gbImagesPoster.TabIndex = 2
        Me.gbImagesPoster.TabStop = False
        Me.gbImagesPoster.Text = "Poster"
        '
        'chkPosterOnly
        '
        Me.chkPosterOnly.AutoSize = True
        Me.chkPosterOnly.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkPosterOnly.Location = New System.Drawing.Point(163, 38)
        Me.chkPosterOnly.Name = "chkPosterOnly"
        Me.chkPosterOnly.Size = New System.Drawing.Size(50, 17)
        Me.chkPosterOnly.TabIndex = 2
        Me.chkPosterOnly.Text = "Only"
        Me.chkPosterOnly.UseVisualStyleBackColor = True
        '
        'txtPosterWidth
        '
        Me.txtPosterWidth.Enabled = False
        Me.txtPosterWidth.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPosterWidth.Location = New System.Drawing.Point(68, 100)
        Me.txtPosterWidth.Name = "txtPosterWidth"
        Me.txtPosterWidth.Size = New System.Drawing.Size(40, 22)
        Me.txtPosterWidth.TabIndex = 6
        '
        'txtPosterHeight
        '
        Me.txtPosterHeight.Enabled = False
        Me.txtPosterHeight.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPosterHeight.Location = New System.Drawing.Point(175, 100)
        Me.txtPosterHeight.Name = "txtPosterHeight"
        Me.txtPosterHeight.Size = New System.Drawing.Size(40, 22)
        Me.txtPosterHeight.TabIndex = 8
        '
        'lblPosterQual
        '
        Me.lblPosterQual.AutoSize = True
        Me.lblPosterQual.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lblPosterQual.Location = New System.Drawing.Point(183, 147)
        Me.lblPosterQual.Name = "lblPosterQual"
        Me.lblPosterQual.Size = New System.Drawing.Size(29, 17)
        Me.lblPosterQual.TabIndex = 11
        Me.lblPosterQual.Text = "100"
        '
        'tbPosterQual
        '
        Me.tbPosterQual.AutoSize = False
        Me.tbPosterQual.LargeChange = 10
        Me.tbPosterQual.Location = New System.Drawing.Point(7, 139)
        Me.tbPosterQual.Maximum = 100
        Me.tbPosterQual.Name = "tbPosterQual"
        Me.tbPosterQual.Size = New System.Drawing.Size(179, 27)
        Me.tbPosterQual.TabIndex = 10
        Me.tbPosterQual.TickFrequency = 10
        Me.tbPosterQual.Value = 100
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(3, 127)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(46, 13)
        Me.Label24.TabIndex = 9
        Me.Label24.Text = "Quality:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(3, 104)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(66, 13)
        Me.Label11.TabIndex = 5
        Me.Label11.Text = "Max Width:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(106, 104)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(69, 13)
        Me.Label12.TabIndex = 7
        Me.Label12.Text = "Max Height:"
        '
        'chkResizePoster
        '
        Me.chkResizePoster.AutoSize = True
        Me.chkResizePoster.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkResizePoster.Location = New System.Drawing.Point(6, 82)
        Me.chkResizePoster.Name = "chkResizePoster"
        Me.chkResizePoster.Size = New System.Drawing.Size(133, 17)
        Me.chkResizePoster.TabIndex = 4
        Me.chkResizePoster.Text = "Automatically Resize:"
        Me.chkResizePoster.UseVisualStyleBackColor = True
        '
        'lblPosterSize
        '
        Me.lblPosterSize.AutoSize = True
        Me.lblPosterSize.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPosterSize.Location = New System.Drawing.Point(4, 18)
        Me.lblPosterSize.Name = "lblPosterSize"
        Me.lblPosterSize.Size = New System.Drawing.Size(80, 13)
        Me.lblPosterSize.TabIndex = 0
        Me.lblPosterSize.Text = "Preferred Size:"
        '
        'cbPosterSize
        '
        Me.cbPosterSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbPosterSize.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.cbPosterSize.FormattingEnabled = True
        Me.cbPosterSize.Location = New System.Drawing.Point(6, 34)
        Me.cbPosterSize.Name = "cbPosterSize"
        Me.cbPosterSize.Size = New System.Drawing.Size(148, 21)
        Me.cbPosterSize.TabIndex = 1
        '
        'chkOverwritePoster
        '
        Me.chkOverwritePoster.AutoSize = True
        Me.chkOverwritePoster.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkOverwritePoster.Location = New System.Drawing.Point(6, 62)
        Me.chkOverwritePoster.Name = "chkOverwritePoster"
        Me.chkOverwritePoster.Size = New System.Drawing.Size(119, 17)
        Me.chkOverwritePoster.TabIndex = 3
        Me.chkOverwritePoster.Text = "Overwrite Existing"
        Me.chkOverwritePoster.UseVisualStyleBackColor = True
        '
        'gbImagesFanart
        '
        Me.gbImagesFanart.Controls.Add(Me.txtFanartWidth)
        Me.gbImagesFanart.Controls.Add(Me.txtFanartHeight)
        Me.gbImagesFanart.Controls.Add(Me.chkFanartOnly)
        Me.gbImagesFanart.Controls.Add(Me.lblFanartQual)
        Me.gbImagesFanart.Controls.Add(Me.tbFanartQual)
        Me.gbImagesFanart.Controls.Add(Me.Label26)
        Me.gbImagesFanart.Controls.Add(Me.Label9)
        Me.gbImagesFanart.Controls.Add(Me.Label10)
        Me.gbImagesFanart.Controls.Add(Me.chkResizeFanart)
        Me.gbImagesFanart.Controls.Add(Me.cbFanartSize)
        Me.gbImagesFanart.Controls.Add(Me.lblFanartSize)
        Me.gbImagesFanart.Controls.Add(Me.chkOverwriteFanart)
        Me.gbImagesFanart.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.gbImagesFanart.Location = New System.Drawing.Point(190, 185)
        Me.gbImagesFanart.Name = "gbImagesFanart"
        Me.gbImagesFanart.Size = New System.Drawing.Size(218, 176)
        Me.gbImagesFanart.TabIndex = 3
        Me.gbImagesFanart.TabStop = False
        Me.gbImagesFanart.Text = "Fanart"
        '
        'txtFanartWidth
        '
        Me.txtFanartWidth.Enabled = False
        Me.txtFanartWidth.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFanartWidth.Location = New System.Drawing.Point(69, 100)
        Me.txtFanartWidth.Name = "txtFanartWidth"
        Me.txtFanartWidth.Size = New System.Drawing.Size(40, 22)
        Me.txtFanartWidth.TabIndex = 6
        '
        'txtFanartHeight
        '
        Me.txtFanartHeight.Enabled = False
        Me.txtFanartHeight.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFanartHeight.Location = New System.Drawing.Point(175, 100)
        Me.txtFanartHeight.Name = "txtFanartHeight"
        Me.txtFanartHeight.Size = New System.Drawing.Size(40, 22)
        Me.txtFanartHeight.TabIndex = 8
        '
        'chkFanartOnly
        '
        Me.chkFanartOnly.AutoSize = True
        Me.chkFanartOnly.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkFanartOnly.Location = New System.Drawing.Point(163, 38)
        Me.chkFanartOnly.Name = "chkFanartOnly"
        Me.chkFanartOnly.Size = New System.Drawing.Size(50, 17)
        Me.chkFanartOnly.TabIndex = 2
        Me.chkFanartOnly.Text = "Only"
        Me.chkFanartOnly.UseVisualStyleBackColor = True
        '
        'lblFanartQual
        '
        Me.lblFanartQual.AutoSize = True
        Me.lblFanartQual.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lblFanartQual.Location = New System.Drawing.Point(183, 151)
        Me.lblFanartQual.Name = "lblFanartQual"
        Me.lblFanartQual.Size = New System.Drawing.Size(29, 17)
        Me.lblFanartQual.TabIndex = 11
        Me.lblFanartQual.Text = "100"
        '
        'tbFanartQual
        '
        Me.tbFanartQual.AutoSize = False
        Me.tbFanartQual.LargeChange = 10
        Me.tbFanartQual.Location = New System.Drawing.Point(6, 143)
        Me.tbFanartQual.Maximum = 100
        Me.tbFanartQual.Name = "tbFanartQual"
        Me.tbFanartQual.Size = New System.Drawing.Size(180, 27)
        Me.tbFanartQual.TabIndex = 10
        Me.tbFanartQual.TickFrequency = 10
        Me.tbFanartQual.Value = 100
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(2, 131)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(46, 13)
        Me.Label26.TabIndex = 9
        Me.Label26.Text = "Quality:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(3, 104)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(66, 13)
        Me.Label9.TabIndex = 5
        Me.Label9.Text = "Max Width:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(107, 104)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(69, 13)
        Me.Label10.TabIndex = 7
        Me.Label10.Text = "Max Height:"
        '
        'chkResizeFanart
        '
        Me.chkResizeFanart.AutoSize = True
        Me.chkResizeFanart.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkResizeFanart.Location = New System.Drawing.Point(6, 82)
        Me.chkResizeFanart.Name = "chkResizeFanart"
        Me.chkResizeFanart.Size = New System.Drawing.Size(133, 17)
        Me.chkResizeFanart.TabIndex = 4
        Me.chkResizeFanart.Text = "Automatically Resize:"
        Me.chkResizeFanart.UseVisualStyleBackColor = True
        '
        'cbFanartSize
        '
        Me.cbFanartSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbFanartSize.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.cbFanartSize.FormattingEnabled = True
        Me.cbFanartSize.Location = New System.Drawing.Point(6, 34)
        Me.cbFanartSize.Name = "cbFanartSize"
        Me.cbFanartSize.Size = New System.Drawing.Size(148, 21)
        Me.cbFanartSize.TabIndex = 1
        '
        'lblFanartSize
        '
        Me.lblFanartSize.AutoSize = True
        Me.lblFanartSize.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFanartSize.Location = New System.Drawing.Point(4, 18)
        Me.lblFanartSize.Name = "lblFanartSize"
        Me.lblFanartSize.Size = New System.Drawing.Size(80, 13)
        Me.lblFanartSize.TabIndex = 0
        Me.lblFanartSize.Text = "Preferred Size:"
        '
        'chkOverwriteFanart
        '
        Me.chkOverwriteFanart.AutoSize = True
        Me.chkOverwriteFanart.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkOverwriteFanart.Location = New System.Drawing.Point(6, 62)
        Me.chkOverwriteFanart.Name = "chkOverwriteFanart"
        Me.chkOverwriteFanart.Size = New System.Drawing.Size(119, 17)
        Me.chkOverwriteFanart.TabIndex = 3
        Me.chkOverwriteFanart.Text = "Overwrite Existing"
        Me.chkOverwriteFanart.UseVisualStyleBackColor = True
        '
        'gbImagesImages
        '
        Me.gbImagesImages.Controls.Add(Me.chkScraperActorThumbs)
        Me.gbImagesImages.Controls.Add(Me.chkNoSaveImagesToNfo)
        Me.gbImagesImages.Controls.Add(Me.chkSingleScrapeImages)
        Me.gbImagesImages.Controls.Add(Me.gbImagesCaching)
        Me.gbImagesImages.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.gbImagesImages.Location = New System.Drawing.Point(3, 3)
        Me.gbImagesImages.Name = "gbImagesImages"
        Me.gbImagesImages.Size = New System.Drawing.Size(184, 168)
        Me.gbImagesImages.TabIndex = 0
        Me.gbImagesImages.TabStop = False
        Me.gbImagesImages.Text = "Images"
        '
        'chkScraperActorThumbs
        '
        Me.chkScraperActorThumbs.CheckAlign = System.Drawing.ContentAlignment.TopLeft
        Me.chkScraperActorThumbs.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkScraperActorThumbs.Location = New System.Drawing.Point(6, 35)
        Me.chkScraperActorThumbs.Name = "chkScraperActorThumbs"
        Me.chkScraperActorThumbs.Size = New System.Drawing.Size(173, 19)
        Me.chkScraperActorThumbs.TabIndex = 1
        Me.chkScraperActorThumbs.Text = "Enable Actor Thumbs"
        Me.chkScraperActorThumbs.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.chkScraperActorThumbs.UseVisualStyleBackColor = True
        '
        'chkNoSaveImagesToNfo
        '
        Me.chkNoSaveImagesToNfo.CheckAlign = System.Drawing.ContentAlignment.TopLeft
        Me.chkNoSaveImagesToNfo.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkNoSaveImagesToNfo.Location = New System.Drawing.Point(6, 53)
        Me.chkNoSaveImagesToNfo.Name = "chkNoSaveImagesToNfo"
        Me.chkNoSaveImagesToNfo.Size = New System.Drawing.Size(172, 34)
        Me.chkNoSaveImagesToNfo.TabIndex = 2
        Me.chkNoSaveImagesToNfo.Text = "Do Not Save Image URLs to Nfo"
        Me.chkNoSaveImagesToNfo.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.chkNoSaveImagesToNfo.UseVisualStyleBackColor = True
        '
        'chkSingleScrapeImages
        '
        Me.chkSingleScrapeImages.CheckAlign = System.Drawing.ContentAlignment.TopLeft
        Me.chkSingleScrapeImages.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSingleScrapeImages.Location = New System.Drawing.Point(6, 16)
        Me.chkSingleScrapeImages.Name = "chkSingleScrapeImages"
        Me.chkSingleScrapeImages.Size = New System.Drawing.Size(173, 19)
        Me.chkSingleScrapeImages.TabIndex = 0
        Me.chkSingleScrapeImages.Text = "Get on Single Scrape"
        Me.chkSingleScrapeImages.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.chkSingleScrapeImages.UseVisualStyleBackColor = True
        '
        'gbImagesCaching
        '
        Me.gbImagesCaching.Controls.Add(Me.chkUseImgCacheUpdaters)
        Me.gbImagesCaching.Controls.Add(Me.chkPersistImgCache)
        Me.gbImagesCaching.Controls.Add(Me.chkUseImgCache)
        Me.gbImagesCaching.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.gbImagesCaching.Location = New System.Drawing.Point(4, 84)
        Me.gbImagesCaching.Name = "gbImagesCaching"
        Me.gbImagesCaching.Size = New System.Drawing.Size(176, 79)
        Me.gbImagesCaching.TabIndex = 3
        Me.gbImagesCaching.TabStop = False
        Me.gbImagesCaching.Text = "Caching"
        '
        'chkUseImgCacheUpdaters
        '
        Me.chkUseImgCacheUpdaters.CheckAlign = System.Drawing.ContentAlignment.TopLeft
        Me.chkUseImgCacheUpdaters.Enabled = False
        Me.chkUseImgCacheUpdaters.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkUseImgCacheUpdaters.Location = New System.Drawing.Point(20, 35)
        Me.chkUseImgCacheUpdaters.Name = "chkUseImgCacheUpdaters"
        Me.chkUseImgCacheUpdaters.Size = New System.Drawing.Size(155, 18)
        Me.chkUseImgCacheUpdaters.TabIndex = 1
        Me.chkUseImgCacheUpdaters.Text = "Use Cache for Scrapers"
        Me.chkUseImgCacheUpdaters.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.chkUseImgCacheUpdaters.UseVisualStyleBackColor = True
        '
        'chkPersistImgCache
        '
        Me.chkPersistImgCache.AutoSize = True
        Me.chkPersistImgCache.Enabled = False
        Me.chkPersistImgCache.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkPersistImgCache.Location = New System.Drawing.Point(20, 58)
        Me.chkPersistImgCache.Name = "chkPersistImgCache"
        Me.chkPersistImgCache.Size = New System.Drawing.Size(144, 17)
        Me.chkPersistImgCache.TabIndex = 2
        Me.chkPersistImgCache.Text = "Persistent Image Cache"
        Me.chkPersistImgCache.UseVisualStyleBackColor = True
        '
        'chkUseImgCache
        '
        Me.chkUseImgCache.AutoSize = True
        Me.chkUseImgCache.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkUseImgCache.Location = New System.Drawing.Point(7, 16)
        Me.chkUseImgCache.Name = "chkUseImgCache"
        Me.chkUseImgCache.Size = New System.Drawing.Size(113, 17)
        Me.chkUseImgCache.TabIndex = 0
        Me.chkUseImgCache.Text = "Use Image Cache"
        Me.chkUseImgCache.UseVisualStyleBackColor = True
        '
        'chkUseETasFA
        '
        Me.chkUseETasFA.CheckAlign = System.Drawing.ContentAlignment.TopLeft
        Me.chkUseETasFA.Enabled = False
        Me.chkUseETasFA.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkUseETasFA.Location = New System.Drawing.Point(25, 84)
        Me.chkUseETasFA.Name = "chkUseETasFA"
        Me.chkUseETasFA.Size = New System.Drawing.Size(171, 30)
        Me.chkUseETasFA.TabIndex = 4
        Me.chkUseETasFA.Text = "Use if no Fanart Found"
        Me.chkUseETasFA.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.chkUseETasFA.UseVisualStyleBackColor = True
        '
        'chkNoSpoilers
        '
        Me.chkNoSpoilers.AutoSize = True
        Me.chkNoSpoilers.Enabled = False
        Me.chkNoSpoilers.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkNoSpoilers.Location = New System.Drawing.Point(25, 67)
        Me.chkNoSpoilers.Name = "chkNoSpoilers"
        Me.chkNoSpoilers.Size = New System.Drawing.Size(85, 17)
        Me.chkNoSpoilers.TabIndex = 3
        Me.chkNoSpoilers.Text = "No Spoilers"
        Me.chkNoSpoilers.UseVisualStyleBackColor = True
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(22, 50)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(102, 13)
        Me.Label15.TabIndex = 1
        Me.Label15.Text = "Number To Create:"
        '
        'txtAutoThumbs
        '
        Me.txtAutoThumbs.Enabled = False
        Me.txtAutoThumbs.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAutoThumbs.Location = New System.Drawing.Point(124, 47)
        Me.txtAutoThumbs.Name = "txtAutoThumbs"
        Me.txtAutoThumbs.Size = New System.Drawing.Size(53, 22)
        Me.txtAutoThumbs.TabIndex = 2
        '
        'chkAutoThumbs
        '
        Me.chkAutoThumbs.CheckAlign = System.Drawing.ContentAlignment.TopLeft
        Me.chkAutoThumbs.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkAutoThumbs.Location = New System.Drawing.Point(6, 17)
        Me.chkAutoThumbs.Name = "chkAutoThumbs"
        Me.chkAutoThumbs.Size = New System.Drawing.Size(188, 30)
        Me.chkAutoThumbs.TabIndex = 0
        Me.chkAutoThumbs.Text = "Extract During Scrapers"
        Me.chkAutoThumbs.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.chkAutoThumbs.UseVisualStyleBackColor = True
        '
        'btnOK
        '
        Me.btnOK.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.btnOK.Location = New System.Drawing.Point(813, 638)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(75, 23)
        Me.btnOK.TabIndex = 0
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'btnApply
        '
        Me.btnApply.Enabled = False
        Me.btnApply.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.btnApply.Location = New System.Drawing.Point(651, 638)
        Me.btnApply.Name = "btnApply"
        Me.btnApply.Size = New System.Drawing.Size(75, 23)
        Me.btnApply.TabIndex = 2
        Me.btnApply.Text = "Apply"
        Me.btnApply.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(732, 638)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 1
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'pnlTop
        '
        Me.pnlTop.BackColor = System.Drawing.Color.SteelBlue
        Me.pnlTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlTop.Controls.Add(Me.Label2)
        Me.pnlTop.Controls.Add(Me.Label4)
        Me.pnlTop.Controls.Add(Me.PictureBox1)
        Me.pnlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTop.Location = New System.Drawing.Point(0, 0)
        Me.pnlTop.Name = "pnlTop"
        Me.pnlTop.Size = New System.Drawing.Size(894, 64)
        Me.pnlTop.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(61, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(245, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Configure Ember's appearance and operation."
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(58, 3)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(107, 32)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Settings"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(7, 8)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(48, 48)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'ilSettings
        '
        Me.ilSettings.ImageStream = CType(resources.GetObject("ilSettings.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ilSettings.TransparentColor = System.Drawing.Color.Transparent
        Me.ilSettings.Images.SetKeyName(0, "process.png")
        Me.ilSettings.Images.SetKeyName(1, "comments.png")
        Me.ilSettings.Images.SetKeyName(2, "film.png")
        Me.ilSettings.Images.SetKeyName(3, "copy_paste.png")
        Me.ilSettings.Images.SetKeyName(4, "attachment.png")
        Me.ilSettings.Images.SetKeyName(5, "folder_full.png")
        Me.ilSettings.Images.SetKeyName(6, "image.png")
        Me.ilSettings.Images.SetKeyName(7, "television.ico")
        Me.ilSettings.Images.SetKeyName(8, "favorite_film.png")
        Me.ilSettings.Images.SetKeyName(9, "settingscheck.png")
        Me.ilSettings.Images.SetKeyName(10, "settingsx.png")
        '
        'tvSettings
        '
        Me.tvSettings.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tvSettings.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tvSettings.FullRowSelect = True
        Me.tvSettings.HideSelection = False
        Me.tvSettings.ImageIndex = 0
        Me.tvSettings.ImageList = Me.ilSettings
        Me.tvSettings.Location = New System.Drawing.Point(5, 147)
        Me.tvSettings.Name = "tvSettings"
        Me.tvSettings.SelectedImageIndex = 0
        Me.tvSettings.ShowLines = False
        Me.tvSettings.ShowPlusMinus = False
        Me.tvSettings.Size = New System.Drawing.Size(242, 440)
        Me.tvSettings.TabIndex = 7
        '
        'pnlGeneral
        '
        Me.pnlGeneral.BackColor = System.Drawing.Color.White
        Me.pnlGeneral.Controls.Add(Me.gbGeneralInterface)
        Me.pnlGeneral.Controls.Add(Me.gbGeneralMiscellaneous)
        Me.pnlGeneral.Location = New System.Drawing.Point(251, 147)
        Me.pnlGeneral.Name = "pnlGeneral"
        Me.pnlGeneral.Size = New System.Drawing.Size(635, 435)
        Me.pnlGeneral.TabIndex = 10
        Me.pnlGeneral.Visible = False
        '
        'gbGeneralInterface
        '
        Me.gbGeneralInterface.Controls.Add(Me.GroupBox29)
        Me.gbGeneralInterface.Controls.Add(Me.Label32)
        Me.gbGeneralInterface.Controls.Add(Me.cbIntLang)
        Me.gbGeneralInterface.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.gbGeneralInterface.Location = New System.Drawing.Point(7, 3)
        Me.gbGeneralInterface.Name = "gbGeneralInterface"
        Me.gbGeneralInterface.Size = New System.Drawing.Size(196, 344)
        Me.gbGeneralInterface.TabIndex = 0
        Me.gbGeneralInterface.TabStop = False
        Me.gbGeneralInterface.Text = "Interface"
        '
        'pnlXBMCCom
        '
        Me.pnlXBMCCom.BackColor = System.Drawing.Color.White
        Me.pnlXBMCCom.Controls.Add(Me.gbProxy)
        Me.pnlXBMCCom.Location = New System.Drawing.Point(900, 900)
        Me.pnlXBMCCom.Name = "pnlXBMCCom"
        Me.pnlXBMCCom.Size = New System.Drawing.Size(617, 400)
        Me.pnlXBMCCom.TabIndex = 18
        Me.pnlXBMCCom.Visible = False
        '
        'gbProxy
        '
        Me.gbProxy.Controls.Add(Me.gbCreds)
        Me.gbProxy.Controls.Add(Me.lblProxyPort)
        Me.gbProxy.Controls.Add(Me.lblProxyURI)
        Me.gbProxy.Controls.Add(Me.txtProxyPort)
        Me.gbProxy.Controls.Add(Me.txtProxyURI)
        Me.gbProxy.Controls.Add(Me.chkEnableProxy)
        Me.gbProxy.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.gbProxy.Location = New System.Drawing.Point(4, 4)
        Me.gbProxy.Name = "gbProxy"
        Me.gbProxy.Size = New System.Drawing.Size(290, 230)
        Me.gbProxy.TabIndex = 0
        Me.gbProxy.TabStop = False
        Me.gbProxy.Text = "Proxy"
        '
        'gbCreds
        '
        Me.gbCreds.Controls.Add(Me.txtProxyDomain)
        Me.gbCreds.Controls.Add(Me.lblProxyDomain)
        Me.gbCreds.Controls.Add(Me.txtProxyPassword)
        Me.gbCreds.Controls.Add(Me.txtProxyUsername)
        Me.gbCreds.Controls.Add(Me.lblProxyUN)
        Me.gbCreds.Controls.Add(Me.lblProxyPW)
        Me.gbCreds.Controls.Add(Me.chkEnableCredentials)
        Me.gbCreds.Enabled = False
        Me.gbCreds.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.gbCreds.Location = New System.Drawing.Point(5, 115)
        Me.gbCreds.Name = "gbCreds"
        Me.gbCreds.Size = New System.Drawing.Size(279, 103)
        Me.gbCreds.TabIndex = 5
        Me.gbCreds.TabStop = False
        Me.gbCreds.Text = "Credentials"
        '
        'txtProxyDomain
        '
        Me.txtProxyDomain.Enabled = False
        Me.txtProxyDomain.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProxyDomain.Location = New System.Drawing.Point(64, 69)
        Me.txtProxyDomain.Name = "txtProxyDomain"
        Me.txtProxyDomain.Size = New System.Drawing.Size(209, 22)
        Me.txtProxyDomain.TabIndex = 6
        '
        'lblProxyDomain
        '
        Me.lblProxyDomain.AutoSize = True
        Me.lblProxyDomain.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProxyDomain.Location = New System.Drawing.Point(14, 72)
        Me.lblProxyDomain.Name = "lblProxyDomain"
        Me.lblProxyDomain.Size = New System.Drawing.Size(50, 13)
        Me.lblProxyDomain.TabIndex = 5
        Me.lblProxyDomain.Text = "Domain:"
        '
        'txtProxyPassword
        '
        Me.txtProxyPassword.Enabled = False
        Me.txtProxyPassword.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProxyPassword.Location = New System.Drawing.Point(201, 39)
        Me.txtProxyPassword.Name = "txtProxyPassword"
        Me.txtProxyPassword.Size = New System.Drawing.Size(72, 22)
        Me.txtProxyPassword.TabIndex = 4
        Me.txtProxyPassword.UseSystemPasswordChar = True
        '
        'txtProxyUsername
        '
        Me.txtProxyUsername.Enabled = False
        Me.txtProxyUsername.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProxyUsername.Location = New System.Drawing.Point(64, 39)
        Me.txtProxyUsername.Name = "txtProxyUsername"
        Me.txtProxyUsername.Size = New System.Drawing.Size(72, 22)
        Me.txtProxyUsername.TabIndex = 2
        '
        'lblProxyUN
        '
        Me.lblProxyUN.AutoSize = True
        Me.lblProxyUN.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProxyUN.Location = New System.Drawing.Point(3, 42)
        Me.lblProxyUN.Name = "lblProxyUN"
        Me.lblProxyUN.Size = New System.Drawing.Size(61, 13)
        Me.lblProxyUN.TabIndex = 1
        Me.lblProxyUN.Text = "Username:"
        '
        'lblProxyPW
        '
        Me.lblProxyPW.AutoSize = True
        Me.lblProxyPW.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProxyPW.Location = New System.Drawing.Point(143, 42)
        Me.lblProxyPW.Name = "lblProxyPW"
        Me.lblProxyPW.Size = New System.Drawing.Size(59, 13)
        Me.lblProxyPW.TabIndex = 3
        Me.lblProxyPW.Text = "Password:"
        '
        'chkEnableCredentials
        '
        Me.chkEnableCredentials.AutoSize = True
        Me.chkEnableCredentials.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkEnableCredentials.Location = New System.Drawing.Point(8, 17)
        Me.chkEnableCredentials.Name = "chkEnableCredentials"
        Me.chkEnableCredentials.Size = New System.Drawing.Size(122, 17)
        Me.chkEnableCredentials.TabIndex = 0
        Me.chkEnableCredentials.Text = "Enable Credentials"
        Me.chkEnableCredentials.UseVisualStyleBackColor = True
        '
        'lblProxyPort
        '
        Me.lblProxyPort.AutoSize = True
        Me.lblProxyPort.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProxyPort.Location = New System.Drawing.Point(9, 88)
        Me.lblProxyPort.Name = "lblProxyPort"
        Me.lblProxyPort.Size = New System.Drawing.Size(61, 13)
        Me.lblProxyPort.TabIndex = 3
        Me.lblProxyPort.Text = "Proxy Port:"
        '
        'lblProxyURI
        '
        Me.lblProxyURI.AutoSize = True
        Me.lblProxyURI.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProxyURI.Location = New System.Drawing.Point(9, 39)
        Me.lblProxyURI.Name = "lblProxyURI"
        Me.lblProxyURI.Size = New System.Drawing.Size(58, 13)
        Me.lblProxyURI.TabIndex = 1
        Me.lblProxyURI.Text = "Proxy URI:"
        '
        'txtProxyPort
        '
        Me.txtProxyPort.Enabled = False
        Me.txtProxyPort.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProxyPort.Location = New System.Drawing.Point(72, 84)
        Me.txtProxyPort.Name = "txtProxyPort"
        Me.txtProxyPort.Size = New System.Drawing.Size(51, 22)
        Me.txtProxyPort.TabIndex = 4
        '
        'txtProxyURI
        '
        Me.txtProxyURI.Enabled = False
        Me.txtProxyURI.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProxyURI.Location = New System.Drawing.Point(11, 54)
        Me.txtProxyURI.Name = "txtProxyURI"
        Me.txtProxyURI.Size = New System.Drawing.Size(267, 22)
        Me.txtProxyURI.TabIndex = 2
        '
        'chkEnableProxy
        '
        Me.chkEnableProxy.AutoSize = True
        Me.chkEnableProxy.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkEnableProxy.Location = New System.Drawing.Point(11, 17)
        Me.chkEnableProxy.Name = "chkEnableProxy"
        Me.chkEnableProxy.Size = New System.Drawing.Size(91, 17)
        Me.chkEnableProxy.TabIndex = 0
        Me.chkEnableProxy.Text = "Enable Proxy"
        Me.chkEnableProxy.UseVisualStyleBackColor = True
        '
        'pnlMovies
        '
        Me.pnlMovies.BackColor = System.Drawing.Color.White
        Me.pnlMovies.Controls.Add(Me.gbMoviesGenreFilter)
        Me.pnlMovies.Controls.Add(Me.gbMoviesFilters)
        Me.pnlMovies.Controls.Add(Me.gbMoviesMissingFilter)
        Me.pnlMovies.Controls.Add(Me.gbMoviesMiscellaneous)
        Me.pnlMovies.Controls.Add(Me.gbMoviesMediaList)
        Me.pnlMovies.Location = New System.Drawing.Point(900, 900)
        Me.pnlMovies.Name = "pnlMovies"
        Me.pnlMovies.Size = New System.Drawing.Size(635, 435)
        Me.pnlMovies.TabIndex = 15
        Me.pnlMovies.Visible = False
        '
        'gbMoviesGenreFilter
        '
        Me.gbMoviesGenreFilter.Controls.Add(Me.lbGenre)
        Me.gbMoviesGenreFilter.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.gbMoviesGenreFilter.Location = New System.Drawing.Point(428, 209)
        Me.gbMoviesGenreFilter.Name = "gbMoviesGenreFilter"
        Me.gbMoviesGenreFilter.Size = New System.Drawing.Size(183, 151)
        Me.gbMoviesGenreFilter.TabIndex = 7
        Me.gbMoviesGenreFilter.TabStop = False
        Me.gbMoviesGenreFilter.Text = "Genre Language Filter"
        '
        'gbMoviesFilters
        '
        Me.gbMoviesFilters.Controls.Add(Me.btnResetMovieFilters)
        Me.gbMoviesFilters.Controls.Add(Me.btnDown)
        Me.gbMoviesFilters.Controls.Add(Me.btnUp)
        Me.gbMoviesFilters.Controls.Add(Me.chkProperCase)
        Me.gbMoviesFilters.Controls.Add(Me.btnRemoveFilter)
        Me.gbMoviesFilters.Controls.Add(Me.btnAddFilter)
        Me.gbMoviesFilters.Controls.Add(Me.txtFilter)
        Me.gbMoviesFilters.Controls.Add(Me.lstFilters)
        Me.gbMoviesFilters.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.gbMoviesFilters.Location = New System.Drawing.Point(229, 7)
        Me.gbMoviesFilters.Name = "gbMoviesFilters"
        Me.gbMoviesFilters.Size = New System.Drawing.Size(382, 200)
        Me.gbMoviesFilters.TabIndex = 6
        Me.gbMoviesFilters.TabStop = False
        Me.gbMoviesFilters.Text = "Folder/File Name Filters"
        '
        'btnResetMovieFilters
        '
        Me.btnResetMovieFilters.Image = CType(resources.GetObject("btnResetMovieFilters.Image"), System.Drawing.Image)
        Me.btnResetMovieFilters.Location = New System.Drawing.Point(355, 11)
        Me.btnResetMovieFilters.Name = "btnResetMovieFilters"
        Me.btnResetMovieFilters.Size = New System.Drawing.Size(23, 23)
        Me.btnResetMovieFilters.TabIndex = 8
        Me.btnResetMovieFilters.UseVisualStyleBackColor = True
        '
        'btnDown
        '
        Me.btnDown.Image = CType(resources.GetObject("btnDown.Image"), System.Drawing.Image)
        Me.btnDown.Location = New System.Drawing.Point(313, 172)
        Me.btnDown.Name = "btnDown"
        Me.btnDown.Size = New System.Drawing.Size(23, 23)
        Me.btnDown.TabIndex = 5
        Me.btnDown.UseVisualStyleBackColor = True
        '
        'btnUp
        '
        Me.btnUp.Image = CType(resources.GetObject("btnUp.Image"), System.Drawing.Image)
        Me.btnUp.Location = New System.Drawing.Point(289, 172)
        Me.btnUp.Name = "btnUp"
        Me.btnUp.Size = New System.Drawing.Size(23, 23)
        Me.btnUp.TabIndex = 4
        Me.btnUp.UseVisualStyleBackColor = True
        '
        'chkProperCase
        '
        Me.chkProperCase.AutoSize = True
        Me.chkProperCase.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkProperCase.Location = New System.Drawing.Point(6, 16)
        Me.chkProperCase.Name = "chkProperCase"
        Me.chkProperCase.Size = New System.Drawing.Size(181, 17)
        Me.chkProperCase.TabIndex = 0
        Me.chkProperCase.Text = "Convert Names to Proper Case"
        Me.chkProperCase.UseVisualStyleBackColor = True
        '
        'btnRemoveFilter
        '
        Me.btnRemoveFilter.Image = CType(resources.GetObject("btnRemoveFilter.Image"), System.Drawing.Image)
        Me.btnRemoveFilter.Location = New System.Drawing.Point(354, 172)
        Me.btnRemoveFilter.Name = "btnRemoveFilter"
        Me.btnRemoveFilter.Size = New System.Drawing.Size(23, 23)
        Me.btnRemoveFilter.TabIndex = 6
        Me.btnRemoveFilter.UseVisualStyleBackColor = True
        '
        'btnAddFilter
        '
        Me.btnAddFilter.Image = CType(resources.GetObject("btnAddFilter.Image"), System.Drawing.Image)
        Me.btnAddFilter.Location = New System.Drawing.Point(247, 172)
        Me.btnAddFilter.Name = "btnAddFilter"
        Me.btnAddFilter.Size = New System.Drawing.Size(23, 23)
        Me.btnAddFilter.TabIndex = 3
        Me.btnAddFilter.UseVisualStyleBackColor = True
        '
        'txtFilter
        '
        Me.txtFilter.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFilter.Location = New System.Drawing.Point(6, 173)
        Me.txtFilter.Name = "txtFilter"
        Me.txtFilter.Size = New System.Drawing.Size(239, 22)
        Me.txtFilter.TabIndex = 2
        '
        'lstFilters
        '
        Me.lstFilters.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lstFilters.FormattingEnabled = True
        Me.lstFilters.Location = New System.Drawing.Point(6, 36)
        Me.lstFilters.Name = "lstFilters"
        Me.lstFilters.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.lstFilters.Size = New System.Drawing.Size(371, 121)
        Me.lstFilters.TabIndex = 1
        '
        'gbMoviesMissingFilter
        '
        Me.gbMoviesMissingFilter.Controls.Add(Me.chkMissingExtra)
        Me.gbMoviesMissingFilter.Controls.Add(Me.chkMissingSubs)
        Me.gbMoviesMissingFilter.Controls.Add(Me.chkMissingTrailer)
        Me.gbMoviesMissingFilter.Controls.Add(Me.chkMissingNFO)
        Me.gbMoviesMissingFilter.Controls.Add(Me.chkMissingFanart)
        Me.gbMoviesMissingFilter.Controls.Add(Me.chkMissingPoster)
        Me.gbMoviesMissingFilter.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.gbMoviesMissingFilter.Location = New System.Drawing.Point(229, 209)
        Me.gbMoviesMissingFilter.Name = "gbMoviesMissingFilter"
        Me.gbMoviesMissingFilter.Size = New System.Drawing.Size(185, 123)
        Me.gbMoviesMissingFilter.TabIndex = 5
        Me.gbMoviesMissingFilter.TabStop = False
        Me.gbMoviesMissingFilter.Text = "Missing Items Filter"
        '
        'chkMissingExtra
        '
        Me.chkMissingExtra.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkMissingExtra.Location = New System.Drawing.Point(8, 98)
        Me.chkMissingExtra.Name = "chkMissingExtra"
        Me.chkMissingExtra.Size = New System.Drawing.Size(174, 17)
        Me.chkMissingExtra.TabIndex = 11
        Me.chkMissingExtra.Text = "Check for Extrathumbs"
        Me.chkMissingExtra.UseVisualStyleBackColor = True
        '
        'chkMissingSubs
        '
        Me.chkMissingSubs.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkMissingSubs.Location = New System.Drawing.Point(8, 82)
        Me.chkMissingSubs.Name = "chkMissingSubs"
        Me.chkMissingSubs.Size = New System.Drawing.Size(174, 17)
        Me.chkMissingSubs.TabIndex = 10
        Me.chkMissingSubs.Text = "Check for Subs"
        Me.chkMissingSubs.UseVisualStyleBackColor = True
        '
        'chkMissingTrailer
        '
        Me.chkMissingTrailer.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkMissingTrailer.Location = New System.Drawing.Point(8, 66)
        Me.chkMissingTrailer.Name = "chkMissingTrailer"
        Me.chkMissingTrailer.Size = New System.Drawing.Size(174, 17)
        Me.chkMissingTrailer.TabIndex = 9
        Me.chkMissingTrailer.Text = "Check for Trailer"
        Me.chkMissingTrailer.UseVisualStyleBackColor = True
        '
        'chkMissingNFO
        '
        Me.chkMissingNFO.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkMissingNFO.Location = New System.Drawing.Point(8, 50)
        Me.chkMissingNFO.Name = "chkMissingNFO"
        Me.chkMissingNFO.Size = New System.Drawing.Size(174, 17)
        Me.chkMissingNFO.TabIndex = 8
        Me.chkMissingNFO.Text = "Check for NFO"
        Me.chkMissingNFO.UseVisualStyleBackColor = True
        '
        'chkMissingFanart
        '
        Me.chkMissingFanart.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkMissingFanart.Location = New System.Drawing.Point(8, 34)
        Me.chkMissingFanart.Name = "chkMissingFanart"
        Me.chkMissingFanart.Size = New System.Drawing.Size(174, 17)
        Me.chkMissingFanart.TabIndex = 7
        Me.chkMissingFanart.Text = "Check for Fanart"
        Me.chkMissingFanart.UseVisualStyleBackColor = True
        '
        'chkMissingPoster
        '
        Me.chkMissingPoster.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkMissingPoster.Location = New System.Drawing.Point(8, 18)
        Me.chkMissingPoster.Name = "chkMissingPoster"
        Me.chkMissingPoster.Size = New System.Drawing.Size(174, 17)
        Me.chkMissingPoster.TabIndex = 6
        Me.chkMissingPoster.Text = "Check for Poster"
        Me.chkMissingPoster.UseVisualStyleBackColor = True
        '
        'gbSourcesBackdrops
        '
        Me.gbSourcesBackdrops.Controls.Add(Me.chkAutoBD)
        Me.gbSourcesBackdrops.Controls.Add(Me.btnBrowse)
        Me.gbSourcesBackdrops.Controls.Add(Me.txtBDPath)
        Me.gbSourcesBackdrops.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.gbSourcesBackdrops.Location = New System.Drawing.Point(243, 326)
        Me.gbSourcesBackdrops.Name = "gbSourcesBackdrops"
        Me.gbSourcesBackdrops.Size = New System.Drawing.Size(366, 69)
        Me.gbSourcesBackdrops.TabIndex = 6
        Me.gbSourcesBackdrops.TabStop = False
        Me.gbSourcesBackdrops.Text = "Backdrops Folder"
        '
        'chkAutoBD
        '
        Me.chkAutoBD.AutoSize = True
        Me.chkAutoBD.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkAutoBD.Location = New System.Drawing.Point(12, 46)
        Me.chkAutoBD.Name = "chkAutoBD"
        Me.chkAutoBD.Size = New System.Drawing.Size(265, 17)
        Me.chkAutoBD.TabIndex = 2
        Me.chkAutoBD.Text = "Automatically Save Fanart To Backdrops Folder"
        Me.chkAutoBD.UseVisualStyleBackColor = True
        '
        'btnBrowse
        '
        Me.btnBrowse.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.btnBrowse.Location = New System.Drawing.Point(336, 15)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(25, 23)
        Me.btnBrowse.TabIndex = 1
        Me.btnBrowse.Text = "..."
        Me.btnBrowse.UseVisualStyleBackColor = True
        '
        'txtBDPath
        '
        Me.txtBDPath.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBDPath.Location = New System.Drawing.Point(7, 17)
        Me.txtBDPath.Name = "txtBDPath"
        Me.txtBDPath.Size = New System.Drawing.Size(323, 22)
        Me.txtBDPath.TabIndex = 0
        '
        'lblCurrent
        '
        Me.lblCurrent.BackColor = System.Drawing.Color.SteelBlue
        Me.lblCurrent.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrent.ForeColor = System.Drawing.Color.White
        Me.lblCurrent.Location = New System.Drawing.Point(26, -1)
        Me.lblCurrent.Name = "lblCurrent"
        Me.lblCurrent.Size = New System.Drawing.Size(489, 25)
        Me.lblCurrent.TabIndex = 0
        Me.lblCurrent.Text = "General"
        '
        'pnlCurrent
        '
        Me.pnlCurrent.BackColor = System.Drawing.Color.SteelBlue
        Me.pnlCurrent.Location = New System.Drawing.Point(516, 119)
        Me.pnlCurrent.Name = "pnlCurrent"
        Me.pnlCurrent.Size = New System.Drawing.Size(371, 25)
        Me.pnlCurrent.TabIndex = 6
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel1.Controls.Add(Me.pbCurrent)
        Me.Panel1.Controls.Add(Me.lblCurrent)
        Me.Panel1.Location = New System.Drawing.Point(5, 119)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(515, 25)
        Me.Panel1.TabIndex = 5
        '
        'pbCurrent
        '
        Me.pbCurrent.Location = New System.Drawing.Point(2, 0)
        Me.pbCurrent.Name = "pbCurrent"
        Me.pbCurrent.Size = New System.Drawing.Size(24, 24)
        Me.pbCurrent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbCurrent.TabIndex = 2
        Me.pbCurrent.TabStop = False
        '
        'pnlExtensions
        '
        Me.pnlExtensions.BackColor = System.Drawing.Color.White
        Me.pnlExtensions.Controls.Add(Me.GroupBox22)
        Me.pnlExtensions.Controls.Add(Me.GroupBox3)
        Me.pnlExtensions.Controls.Add(Me.GroupBox18)
        Me.pnlExtensions.Location = New System.Drawing.Point(855, 706)
        Me.pnlExtensions.Name = "pnlExtensions"
        Me.pnlExtensions.Size = New System.Drawing.Size(617, 400)
        Me.pnlExtensions.TabIndex = 17
        Me.pnlExtensions.Visible = False
        '
        'GroupBox22
        '
        Me.GroupBox22.Controls.Add(Me.btnRemoveNoStack)
        Me.GroupBox22.Controls.Add(Me.btnAddNoStack)
        Me.GroupBox22.Controls.Add(Me.txtNoStack)
        Me.GroupBox22.Controls.Add(Me.lstNoStack)
        Me.GroupBox22.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.GroupBox22.Location = New System.Drawing.Point(202, 6)
        Me.GroupBox22.Name = "GroupBox22"
        Me.GroupBox22.Size = New System.Drawing.Size(194, 199)
        Me.GroupBox22.TabIndex = 1
        Me.GroupBox22.TabStop = False
        Me.GroupBox22.Text = "No Stack Extensions"
        '
        'btnRemoveNoStack
        '
        Me.btnRemoveNoStack.Image = CType(resources.GetObject("btnRemoveNoStack.Image"), System.Drawing.Image)
        Me.btnRemoveNoStack.Location = New System.Drawing.Point(160, 167)
        Me.btnRemoveNoStack.Name = "btnRemoveNoStack"
        Me.btnRemoveNoStack.Size = New System.Drawing.Size(23, 23)
        Me.btnRemoveNoStack.TabIndex = 3
        Me.btnRemoveNoStack.UseVisualStyleBackColor = True
        '
        'btnAddNoStack
        '
        Me.btnAddNoStack.Image = CType(resources.GetObject("btnAddNoStack.Image"), System.Drawing.Image)
        Me.btnAddNoStack.Location = New System.Drawing.Point(73, 167)
        Me.btnAddNoStack.Name = "btnAddNoStack"
        Me.btnAddNoStack.Size = New System.Drawing.Size(23, 23)
        Me.btnAddNoStack.TabIndex = 2
        Me.btnAddNoStack.UseVisualStyleBackColor = True
        '
        'txtNoStack
        '
        Me.txtNoStack.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNoStack.Location = New System.Drawing.Point(11, 168)
        Me.txtNoStack.Name = "txtNoStack"
        Me.txtNoStack.Size = New System.Drawing.Size(61, 22)
        Me.txtNoStack.TabIndex = 1
        '
        'lstNoStack
        '
        Me.lstNoStack.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lstNoStack.FormattingEnabled = True
        Me.lstNoStack.Location = New System.Drawing.Point(11, 15)
        Me.lstNoStack.Name = "lstNoStack"
        Me.lstNoStack.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.lstNoStack.Size = New System.Drawing.Size(171, 134)
        Me.lstNoStack.Sorted = True
        Me.lstNoStack.TabIndex = 0
        '
        'GroupBox18
        '
        Me.GroupBox18.Controls.Add(Me.btnResetValidExts)
        Me.GroupBox18.Controls.Add(Me.btnRemMovieExt)
        Me.GroupBox18.Controls.Add(Me.btnAddMovieExt)
        Me.GroupBox18.Controls.Add(Me.txtMovieExt)
        Me.GroupBox18.Controls.Add(Me.lstMovieExts)
        Me.GroupBox18.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.GroupBox18.Location = New System.Drawing.Point(3, 6)
        Me.GroupBox18.Name = "GroupBox18"
        Me.GroupBox18.Size = New System.Drawing.Size(192, 385)
        Me.GroupBox18.TabIndex = 0
        Me.GroupBox18.TabStop = False
        Me.GroupBox18.Text = "Valid Video Extensions"
        '
        'btnResetValidExts
        '
        Me.btnResetValidExts.Image = CType(resources.GetObject("btnResetValidExts.Image"), System.Drawing.Image)
        Me.btnResetValidExts.Location = New System.Drawing.Point(164, 12)
        Me.btnResetValidExts.Name = "btnResetValidExts"
        Me.btnResetValidExts.Size = New System.Drawing.Size(23, 23)
        Me.btnResetValidExts.TabIndex = 4
        Me.btnResetValidExts.UseVisualStyleBackColor = True
        '
        'btnRemMovieExt
        '
        Me.btnRemMovieExt.Image = CType(resources.GetObject("btnRemMovieExt.Image"), System.Drawing.Image)
        Me.btnRemMovieExt.Location = New System.Drawing.Point(163, 356)
        Me.btnRemMovieExt.Name = "btnRemMovieExt"
        Me.btnRemMovieExt.Size = New System.Drawing.Size(23, 23)
        Me.btnRemMovieExt.TabIndex = 3
        Me.btnRemMovieExt.UseVisualStyleBackColor = True
        '
        'btnAddMovieExt
        '
        Me.btnAddMovieExt.Image = CType(resources.GetObject("btnAddMovieExt.Image"), System.Drawing.Image)
        Me.btnAddMovieExt.Location = New System.Drawing.Point(68, 356)
        Me.btnAddMovieExt.Name = "btnAddMovieExt"
        Me.btnAddMovieExt.Size = New System.Drawing.Size(23, 23)
        Me.btnAddMovieExt.TabIndex = 2
        Me.btnAddMovieExt.UseVisualStyleBackColor = True
        '
        'txtMovieExt
        '
        Me.txtMovieExt.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMovieExt.Location = New System.Drawing.Point(6, 357)
        Me.txtMovieExt.Name = "txtMovieExt"
        Me.txtMovieExt.Size = New System.Drawing.Size(61, 22)
        Me.txtMovieExt.TabIndex = 1
        '
        'lstMovieExts
        '
        Me.lstMovieExts.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lstMovieExts.FormattingEnabled = True
        Me.lstMovieExts.Location = New System.Drawing.Point(6, 37)
        Me.lstMovieExts.Name = "lstMovieExts"
        Me.lstMovieExts.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.lstMovieExts.Size = New System.Drawing.Size(180, 303)
        Me.lstMovieExts.Sorted = True
        Me.lstMovieExts.TabIndex = 0
        '
        'pnlSources
        '
        Me.pnlSources.BackColor = System.Drawing.Color.White
        Me.pnlSources.Controls.Add(Me.btnEditSource)
        Me.pnlSources.Controls.Add(Me.gbSourcesMiscellaneous)
        Me.pnlSources.Controls.Add(Me.lvMovies)
        Me.pnlSources.Controls.Add(Me.btnMovieRem)
        Me.pnlSources.Controls.Add(Me.btnMovieAddFolder)
        Me.pnlSources.Controls.Add(Me.gbSourcesFileNaming)
        Me.pnlSources.Controls.Add(Me.gbSourcesBackdrops)
        Me.pnlSources.Location = New System.Drawing.Point(900, 900)
        Me.pnlSources.Name = "pnlSources"
        Me.pnlSources.Size = New System.Drawing.Size(635, 435)
        Me.pnlSources.TabIndex = 13
        Me.pnlSources.Visible = False
        '
        'btnEditSource
        '
        Me.btnEditSource.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditSource.Image = CType(resources.GetObject("btnEditSource.Image"), System.Drawing.Image)
        Me.btnEditSource.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEditSource.Location = New System.Drawing.Point(506, 35)
        Me.btnEditSource.Name = "btnEditSource"
        Me.btnEditSource.Size = New System.Drawing.Size(104, 23)
        Me.btnEditSource.TabIndex = 2
        Me.btnEditSource.Text = "Edit Source"
        Me.btnEditSource.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEditSource.UseVisualStyleBackColor = True
        '
        'gbSourcesMiscellaneous
        '
        Me.gbSourcesMiscellaneous.Controls.Add(Me.chkVideoTSParentXBMC)
        Me.gbSourcesMiscellaneous.Controls.Add(Me.chkScanOrderModify)
        Me.gbSourcesMiscellaneous.Controls.Add(Me.chkSortBeforeScan)
        Me.gbSourcesMiscellaneous.Controls.Add(Me.chkIgnoreLastScan)
        Me.gbSourcesMiscellaneous.Controls.Add(Me.chkCleanDB)
        Me.gbSourcesMiscellaneous.Controls.Add(Me.chkAutoDetectVTS)
        Me.gbSourcesMiscellaneous.Controls.Add(Me.chkSkipStackedSizeCheck)
        Me.gbSourcesMiscellaneous.Controls.Add(Me.Label21)
        Me.gbSourcesMiscellaneous.Controls.Add(Me.txtSkipLessThan)
        Me.gbSourcesMiscellaneous.Controls.Add(Me.Label20)
        Me.gbSourcesMiscellaneous.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.gbSourcesMiscellaneous.Location = New System.Drawing.Point(5, 113)
        Me.gbSourcesMiscellaneous.Name = "gbSourcesMiscellaneous"
        Me.gbSourcesMiscellaneous.Size = New System.Drawing.Size(233, 282)
        Me.gbSourcesMiscellaneous.TabIndex = 4
        Me.gbSourcesMiscellaneous.TabStop = False
        Me.gbSourcesMiscellaneous.Text = "Miscellaneous Options"
        '
        'chkVideoTSParentXBMC
        '
        Me.chkVideoTSParentXBMC.CheckAlign = System.Drawing.ContentAlignment.TopLeft
        Me.chkVideoTSParentXBMC.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkVideoTSParentXBMC.Location = New System.Drawing.Point(5, 114)
        Me.chkVideoTSParentXBMC.Name = "chkVideoTSParentXBMC"
        Me.chkVideoTSParentXBMC.Size = New System.Drawing.Size(222, 33)
        Me.chkVideoTSParentXBMC.TabIndex = 5
        Me.chkVideoTSParentXBMC.Text = "Frodo Compatible VIDEO_TS File Replacement/Naming"
        Me.chkVideoTSParentXBMC.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.chkVideoTSParentXBMC.UseVisualStyleBackColor = True
        '
        'chkScanOrderModify
        '
        Me.chkScanOrderModify.CheckAlign = System.Drawing.ContentAlignment.TopLeft
        Me.chkScanOrderModify.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkScanOrderModify.Location = New System.Drawing.Point(5, 213)
        Me.chkScanOrderModify.Name = "chkScanOrderModify"
        Me.chkScanOrderModify.Size = New System.Drawing.Size(222, 33)
        Me.chkScanOrderModify.TabIndex = 8
        Me.chkScanOrderModify.Text = "Scan in order of last write time."
        Me.chkScanOrderModify.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.chkScanOrderModify.UseVisualStyleBackColor = True
        '
        'chkSortBeforeScan
        '
        Me.chkSortBeforeScan.CheckAlign = System.Drawing.ContentAlignment.TopLeft
        Me.chkSortBeforeScan.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSortBeforeScan.Location = New System.Drawing.Point(5, 147)
        Me.chkSortBeforeScan.Name = "chkSortBeforeScan"
        Me.chkSortBeforeScan.Size = New System.Drawing.Size(222, 33)
        Me.chkSortBeforeScan.TabIndex = 6
        Me.chkSortBeforeScan.Text = "Sort files into folders before each library update"
        Me.chkSortBeforeScan.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.chkSortBeforeScan.UseVisualStyleBackColor = True
        '
        'chkIgnoreLastScan
        '
        Me.chkIgnoreLastScan.CheckAlign = System.Drawing.ContentAlignment.TopLeft
        Me.chkIgnoreLastScan.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkIgnoreLastScan.Location = New System.Drawing.Point(5, 180)
        Me.chkIgnoreLastScan.Name = "chkIgnoreLastScan"
        Me.chkIgnoreLastScan.Size = New System.Drawing.Size(222, 33)
        Me.chkIgnoreLastScan.TabIndex = 7
        Me.chkIgnoreLastScan.Text = "Always scan all media when updating library"
        Me.chkIgnoreLastScan.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.chkIgnoreLastScan.UseVisualStyleBackColor = True
        '
        'chkCleanDB
        '
        Me.chkCleanDB.CheckAlign = System.Drawing.ContentAlignment.TopLeft
        Me.chkCleanDB.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkCleanDB.Location = New System.Drawing.Point(5, 246)
        Me.chkCleanDB.Name = "chkCleanDB"
        Me.chkCleanDB.Size = New System.Drawing.Size(222, 33)
        Me.chkCleanDB.TabIndex = 9
        Me.chkCleanDB.Text = "Clean database after updating library"
        Me.chkCleanDB.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.chkCleanDB.UseVisualStyleBackColor = True
        '
        'chkAutoDetectVTS
        '
        Me.chkAutoDetectVTS.CheckAlign = System.Drawing.ContentAlignment.TopLeft
        Me.chkAutoDetectVTS.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkAutoDetectVTS.Location = New System.Drawing.Point(5, 81)
        Me.chkAutoDetectVTS.Name = "chkAutoDetectVTS"
        Me.chkAutoDetectVTS.Size = New System.Drawing.Size(222, 33)
        Me.chkAutoDetectVTS.TabIndex = 4
        Me.chkAutoDetectVTS.Text = "Recognize VIDEO_TS Folders"
        Me.chkAutoDetectVTS.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.chkAutoDetectVTS.UseVisualStyleBackColor = True
        '
        'chkSkipStackedSizeCheck
        '
        Me.chkSkipStackedSizeCheck.AutoSize = True
        Me.chkSkipStackedSizeCheck.CheckAlign = System.Drawing.ContentAlignment.TopLeft
        Me.chkSkipStackedSizeCheck.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSkipStackedSizeCheck.Location = New System.Drawing.Point(27, 58)
        Me.chkSkipStackedSizeCheck.Name = "chkSkipStackedSizeCheck"
        Me.chkSkipStackedSizeCheck.Size = New System.Drawing.Size(188, 17)
        Me.chkSkipStackedSizeCheck.TabIndex = 3
        Me.chkSkipStackedSizeCheck.Text = "Skip Size Check of Stacked Files"
        Me.chkSkipStackedSizeCheck.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.chkSkipStackedSizeCheck.UseVisualStyleBackColor = True
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(133, 39)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(24, 13)
        Me.Label21.TabIndex = 2
        Me.Label21.Text = "MB"
        '
        'txtSkipLessThan
        '
        Me.txtSkipLessThan.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSkipLessThan.Location = New System.Drawing.Point(27, 35)
        Me.txtSkipLessThan.Name = "txtSkipLessThan"
        Me.txtSkipLessThan.Size = New System.Drawing.Size(100, 22)
        Me.txtSkipLessThan.TabIndex = 1
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(4, 19)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(122, 13)
        Me.Label20.TabIndex = 0
        Me.Label20.Text = "Skip files smaller than:"
        '
        'pnlImages
        '
        Me.pnlImages.BackColor = System.Drawing.Color.White
        Me.pnlImages.Controls.Add(Me.gbImagesTrailers)
        Me.pnlImages.Controls.Add(Me.gbImagesImages)
        Me.pnlImages.Controls.Add(Me.gbImagesFanart)
        Me.pnlImages.Controls.Add(Me.gbImagesPoster)
        Me.pnlImages.Controls.Add(Me.gbImagesExtrathumbs)
        Me.pnlImages.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlImages.Location = New System.Drawing.Point(900, 900)
        Me.pnlImages.Name = "pnlImages"
        Me.pnlImages.Size = New System.Drawing.Size(635, 435)
        Me.pnlImages.TabIndex = 12
        Me.pnlImages.Visible = False
        '
        'gbImagesTrailers
        '
        Me.gbImagesTrailers.Controls.Add(Me.cbTrailerQuality)
        Me.gbImagesTrailers.Controls.Add(Me.lblPreferredQuality)
        Me.gbImagesTrailers.Controls.Add(Me.chkDeleteAllTrailers)
        Me.gbImagesTrailers.Controls.Add(Me.chkOverwriteTrailer)
        Me.gbImagesTrailers.Controls.Add(Me.chkNoDLTrailer)
        Me.gbImagesTrailers.Controls.Add(Me.chkSingleScrapeTrailer)
        Me.gbImagesTrailers.Controls.Add(Me.chkUpdaterTrailer)
        Me.gbImagesTrailers.Controls.Add(Me.chkDownloadTrailer)
        Me.gbImagesTrailers.Location = New System.Drawing.Point(4, 172)
        Me.gbImagesTrailers.Name = "gbImagesTrailers"
        Me.gbImagesTrailers.Size = New System.Drawing.Size(183, 230)
        Me.gbImagesTrailers.TabIndex = 1
        Me.gbImagesTrailers.TabStop = False
        Me.gbImagesTrailers.Text = "Trailers"
        '
        'cbTrailerQuality
        '
        Me.cbTrailerQuality.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTrailerQuality.Enabled = False
        Me.cbTrailerQuality.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.cbTrailerQuality.FormattingEnabled = True
        Me.cbTrailerQuality.Location = New System.Drawing.Point(33, 204)
        Me.cbTrailerQuality.Name = "cbTrailerQuality"
        Me.cbTrailerQuality.Size = New System.Drawing.Size(106, 21)
        Me.cbTrailerQuality.TabIndex = 7
        '
        'lblPreferredQuality
        '
        Me.lblPreferredQuality.AutoSize = True
        Me.lblPreferredQuality.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPreferredQuality.Location = New System.Drawing.Point(31, 189)
        Me.lblPreferredQuality.Name = "lblPreferredQuality"
        Me.lblPreferredQuality.Size = New System.Drawing.Size(96, 13)
        Me.lblPreferredQuality.TabIndex = 6
        Me.lblPreferredQuality.Text = "Preferred Quality:"
        '
        'chkDeleteAllTrailers
        '
        Me.chkDeleteAllTrailers.CheckAlign = System.Drawing.ContentAlignment.TopLeft
        Me.chkDeleteAllTrailers.Enabled = False
        Me.chkDeleteAllTrailers.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkDeleteAllTrailers.Location = New System.Drawing.Point(25, 163)
        Me.chkDeleteAllTrailers.Name = "chkDeleteAllTrailers"
        Me.chkDeleteAllTrailers.Size = New System.Drawing.Size(152, 27)
        Me.chkDeleteAllTrailers.TabIndex = 5
        Me.chkDeleteAllTrailers.Text = "Delete All Existing"
        Me.chkDeleteAllTrailers.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.chkDeleteAllTrailers.UseVisualStyleBackColor = True
        '
        'chkOverwriteTrailer
        '
        Me.chkOverwriteTrailer.AutoSize = True
        Me.chkOverwriteTrailer.Enabled = False
        Me.chkOverwriteTrailer.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkOverwriteTrailer.Location = New System.Drawing.Point(25, 143)
        Me.chkOverwriteTrailer.Name = "chkOverwriteTrailer"
        Me.chkOverwriteTrailer.Size = New System.Drawing.Size(119, 17)
        Me.chkOverwriteTrailer.TabIndex = 4
        Me.chkOverwriteTrailer.Text = "Overwrite Existing"
        Me.chkOverwriteTrailer.UseVisualStyleBackColor = True
        '
        'chkNoDLTrailer
        '
        Me.chkNoDLTrailer.CheckAlign = System.Drawing.ContentAlignment.TopLeft
        Me.chkNoDLTrailer.Enabled = False
        Me.chkNoDLTrailer.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkNoDLTrailer.Location = New System.Drawing.Point(25, 72)
        Me.chkNoDLTrailer.Name = "chkNoDLTrailer"
        Me.chkNoDLTrailer.Size = New System.Drawing.Size(151, 30)
        Me.chkNoDLTrailer.TabIndex = 2
        Me.chkNoDLTrailer.Text = "Only Get URLs When Scraping"
        Me.chkNoDLTrailer.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.chkNoDLTrailer.UseVisualStyleBackColor = True
        '
        'chkSingleScrapeTrailer
        '
        Me.chkSingleScrapeTrailer.CheckAlign = System.Drawing.ContentAlignment.TopLeft
        Me.chkSingleScrapeTrailer.Enabled = False
        Me.chkSingleScrapeTrailer.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSingleScrapeTrailer.Location = New System.Drawing.Point(25, 106)
        Me.chkSingleScrapeTrailer.Name = "chkSingleScrapeTrailer"
        Me.chkSingleScrapeTrailer.Size = New System.Drawing.Size(154, 34)
        Me.chkSingleScrapeTrailer.TabIndex = 3
        Me.chkSingleScrapeTrailer.Text = "Get During Single Scrape"
        Me.chkSingleScrapeTrailer.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.chkSingleScrapeTrailer.UseVisualStyleBackColor = True
        '
        'chkUpdaterTrailer
        '
        Me.chkUpdaterTrailer.CheckAlign = System.Drawing.ContentAlignment.TopLeft
        Me.chkUpdaterTrailer.Enabled = False
        Me.chkUpdaterTrailer.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkUpdaterTrailer.Location = New System.Drawing.Point(25, 38)
        Me.chkUpdaterTrailer.Name = "chkUpdaterTrailer"
        Me.chkUpdaterTrailer.Size = New System.Drawing.Size(151, 33)
        Me.chkUpdaterTrailer.TabIndex = 1
        Me.chkUpdaterTrailer.Text = "Get During Automated Scrapers"
        Me.chkUpdaterTrailer.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.chkUpdaterTrailer.UseVisualStyleBackColor = True
        '
        'chkDownloadTrailer
        '
        Me.chkDownloadTrailer.AutoSize = True
        Me.chkDownloadTrailer.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkDownloadTrailer.Location = New System.Drawing.Point(12, 16)
        Me.chkDownloadTrailer.Name = "chkDownloadTrailer"
        Me.chkDownloadTrailer.Size = New System.Drawing.Size(140, 17)
        Me.chkDownloadTrailer.TabIndex = 0
        Me.chkDownloadTrailer.Text = "Enable Trailer Support"
        Me.chkDownloadTrailer.UseVisualStyleBackColor = True
        '
        'gbImagesExtrathumbs
        '
        Me.gbImagesExtrathumbs.Controls.Add(Me.chkAutoETSize)
        Me.gbImagesExtrathumbs.Controls.Add(Me.cbAutoETSize)
        Me.gbImagesExtrathumbs.Controls.Add(Me.txtAutoThumbs)
        Me.gbImagesExtrathumbs.Controls.Add(Me.gbImagesSizing)
        Me.gbImagesExtrathumbs.Controls.Add(Me.chkAutoThumbs)
        Me.gbImagesExtrathumbs.Controls.Add(Me.chkUseETasFA)
        Me.gbImagesExtrathumbs.Controls.Add(Me.Label15)
        Me.gbImagesExtrathumbs.Controls.Add(Me.chkNoSpoilers)
        Me.gbImagesExtrathumbs.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.gbImagesExtrathumbs.Location = New System.Drawing.Point(412, 3)
        Me.gbImagesExtrathumbs.Name = "gbImagesExtrathumbs"
        Me.gbImagesExtrathumbs.Size = New System.Drawing.Size(199, 358)
        Me.gbImagesExtrathumbs.TabIndex = 4
        Me.gbImagesExtrathumbs.TabStop = False
        Me.gbImagesExtrathumbs.Text = "Extrathumbs"
        '
        'chkAutoETSize
        '
        Me.chkAutoETSize.CheckAlign = System.Drawing.ContentAlignment.TopLeft
        Me.chkAutoETSize.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkAutoETSize.Location = New System.Drawing.Point(6, 236)
        Me.chkAutoETSize.Name = "chkAutoETSize"
        Me.chkAutoETSize.Size = New System.Drawing.Size(188, 43)
        Me.chkAutoETSize.TabIndex = 6
        Me.chkAutoETSize.Text = "Download All Fanart Images of the Following Size as Extrathumbs:"
        Me.chkAutoETSize.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.chkAutoETSize.UseVisualStyleBackColor = True
        '
        'cbAutoETSize
        '
        Me.cbAutoETSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbAutoETSize.Enabled = False
        Me.cbAutoETSize.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.cbAutoETSize.FormattingEnabled = True
        Me.cbAutoETSize.Location = New System.Drawing.Point(26, 283)
        Me.cbAutoETSize.Name = "cbAutoETSize"
        Me.cbAutoETSize.Size = New System.Drawing.Size(148, 21)
        Me.cbAutoETSize.TabIndex = 7
        '
        'gbImagesSizing
        '
        Me.gbImagesSizing.Controls.Add(Me.txtETWidth)
        Me.gbImagesSizing.Controls.Add(Me.txtETHeight)
        Me.gbImagesSizing.Controls.Add(Me.chkETPadding)
        Me.gbImagesSizing.Controls.Add(Me.Label28)
        Me.gbImagesSizing.Controls.Add(Me.Label29)
        Me.gbImagesSizing.Controls.Add(Me.rbETCustom)
        Me.gbImagesSizing.Controls.Add(Me.rbETNative)
        Me.gbImagesSizing.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.gbImagesSizing.Location = New System.Drawing.Point(7, 120)
        Me.gbImagesSizing.Name = "gbImagesSizing"
        Me.gbImagesSizing.Size = New System.Drawing.Size(185, 104)
        Me.gbImagesSizing.TabIndex = 5
        Me.gbImagesSizing.TabStop = False
        Me.gbImagesSizing.Text = "Sizing (Extracted Frames)"
        '
        'txtETWidth
        '
        Me.txtETWidth.Enabled = False
        Me.txtETWidth.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtETWidth.Location = New System.Drawing.Point(61, 57)
        Me.txtETWidth.Name = "txtETWidth"
        Me.txtETWidth.Size = New System.Drawing.Size(40, 22)
        Me.txtETWidth.TabIndex = 3
        '
        'txtETHeight
        '
        Me.txtETHeight.Enabled = False
        Me.txtETHeight.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtETHeight.Location = New System.Drawing.Point(143, 57)
        Me.txtETHeight.Name = "txtETHeight"
        Me.txtETHeight.Size = New System.Drawing.Size(40, 22)
        Me.txtETHeight.TabIndex = 5
        '
        'chkETPadding
        '
        Me.chkETPadding.AutoSize = True
        Me.chkETPadding.Enabled = False
        Me.chkETPadding.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkETPadding.Location = New System.Drawing.Point(21, 81)
        Me.chkETPadding.Name = "chkETPadding"
        Me.chkETPadding.Size = New System.Drawing.Size(69, 17)
        Me.chkETPadding.TabIndex = 6
        Me.chkETPadding.Text = "Padding"
        Me.chkETPadding.UseVisualStyleBackColor = True
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(17, 61)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(42, 13)
        Me.Label28.TabIndex = 2
        Me.Label28.Text = "Width:"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(98, 61)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(45, 13)
        Me.Label29.TabIndex = 4
        Me.Label29.Text = "Height:"
        '
        'rbETCustom
        '
        Me.rbETCustom.AutoSize = True
        Me.rbETCustom.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbETCustom.Location = New System.Drawing.Point(7, 38)
        Me.rbETCustom.Name = "rbETCustom"
        Me.rbETCustom.Size = New System.Drawing.Size(109, 17)
        Me.rbETCustom.TabIndex = 1
        Me.rbETCustom.TabStop = True
        Me.rbETCustom.Text = "Use Custom Size"
        Me.rbETCustom.UseVisualStyleBackColor = True
        '
        'rbETNative
        '
        Me.rbETNative.AutoSize = True
        Me.rbETNative.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbETNative.Location = New System.Drawing.Point(7, 20)
        Me.rbETNative.Name = "rbETNative"
        Me.rbETNative.Size = New System.Drawing.Size(138, 17)
        Me.rbETNative.TabIndex = 0
        Me.rbETNative.TabStop = True
        Me.rbETNative.Text = "Use Native Resolution"
        Me.rbETNative.UseVisualStyleBackColor = True
        '
        'fbdBrowse
        '
        Me.fbdBrowse.Description = "Select the folder where you wish to store your backdrops."
        '
        'pnlTVSources
        '
        Me.pnlTVSources.BackColor = System.Drawing.Color.White
        Me.pnlTVSources.Controls.Add(Me.TabControl2)
        Me.pnlTVSources.Location = New System.Drawing.Point(900, 900)
        Me.pnlTVSources.Name = "pnlTVSources"
        Me.pnlTVSources.Size = New System.Drawing.Size(635, 435)
        Me.pnlTVSources.TabIndex = 11
        Me.pnlTVSources.Visible = False
        '
        'TabControl2
        '
        Me.TabControl2.Controls.Add(Me.TabPage3)
        Me.TabControl2.Controls.Add(Me.TabPage4)
        Me.TabControl2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.TabControl2.Location = New System.Drawing.Point(3, 4)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(620, 400)
        Me.TabControl2.TabIndex = 0
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.btnTVShowFrodo)
        Me.TabPage3.Controls.Add(Me.lvTVSources)
        Me.TabPage3.Controls.Add(Me.gbMiscTVSourceOpts)
        Me.TabPage3.Controls.Add(Me.btnAddTVSource)
        Me.TabPage3.Controls.Add(Me.btnEditTVSource)
        Me.TabPage3.Controls.Add(Me.btnRemTVSource)
        Me.TabPage3.Controls.Add(Me.gbTVNaming)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(612, 374)
        Me.TabPage3.TabIndex = 0
        Me.TabPage3.Text = "General"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'btnTVShowFrodo
        '
        Me.btnTVShowFrodo.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.btnTVShowFrodo.Location = New System.Drawing.Point(22, 320)
        Me.btnTVShowFrodo.Name = "btnTVShowFrodo"
        Me.btnTVShowFrodo.Size = New System.Drawing.Size(116, 23)
        Me.btnTVShowFrodo.TabIndex = 5
        Me.btnTVShowFrodo.Text = "XBMC Frodo"
        Me.btnTVShowFrodo.UseVisualStyleBackColor = True
        '
        'lvTVSources
        '
        Me.lvTVSources.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.lvTVSources.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lvTVSources.FullRowSelect = True
        Me.lvTVSources.HideSelection = False
        Me.lvTVSources.Location = New System.Drawing.Point(6, 4)
        Me.lvTVSources.Name = "lvTVSources"
        Me.lvTVSources.Size = New System.Drawing.Size(483, 105)
        Me.lvTVSources.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.lvTVSources.TabIndex = 0
        Me.lvTVSources.UseCompatibleStateImageBehavior = False
        Me.lvTVSources.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Width = 0
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Name"
        Me.ColumnHeader2.Width = 94
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Path"
        Me.ColumnHeader3.Width = 368
        '
        'gbMiscTVSourceOpts
        '
        Me.gbMiscTVSourceOpts.Controls.Add(Me.Label6)
        Me.gbMiscTVSourceOpts.Controls.Add(Me.txtTVSkipLessThan)
        Me.gbMiscTVSourceOpts.Controls.Add(Me.Label7)
        Me.gbMiscTVSourceOpts.Controls.Add(Me.chkTVScanOrderModify)
        Me.gbMiscTVSourceOpts.Controls.Add(Me.chkTVIgnoreLastScan)
        Me.gbMiscTVSourceOpts.Controls.Add(Me.chkTVCleanDB)
        Me.gbMiscTVSourceOpts.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.gbMiscTVSourceOpts.Location = New System.Drawing.Point(6, 110)
        Me.gbMiscTVSourceOpts.Name = "gbMiscTVSourceOpts"
        Me.gbMiscTVSourceOpts.Size = New System.Drawing.Size(151, 200)
        Me.gbMiscTVSourceOpts.TabIndex = 4
        Me.gbMiscTVSourceOpts.TabStop = False
        Me.gbMiscTVSourceOpts.Text = "Miscellaneous Options"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(114, 39)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(24, 13)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "MB"
        '
        'txtTVSkipLessThan
        '
        Me.txtTVSkipLessThan.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTVSkipLessThan.Location = New System.Drawing.Point(11, 34)
        Me.txtTVSkipLessThan.Name = "txtTVSkipLessThan"
        Me.txtTVSkipLessThan.Size = New System.Drawing.Size(100, 22)
        Me.txtTVSkipLessThan.TabIndex = 0
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(6, 18)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(122, 13)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Skip files smaller than:"
        '
        'chkTVScanOrderModify
        '
        Me.chkTVScanOrderModify.CheckAlign = System.Drawing.ContentAlignment.TopLeft
        Me.chkTVScanOrderModify.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkTVScanOrderModify.Location = New System.Drawing.Point(4, 110)
        Me.chkTVScanOrderModify.Name = "chkTVScanOrderModify"
        Me.chkTVScanOrderModify.Size = New System.Drawing.Size(142, 43)
        Me.chkTVScanOrderModify.TabIndex = 4
        Me.chkTVScanOrderModify.Text = "Scan in order of last write time"
        Me.chkTVScanOrderModify.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.chkTVScanOrderModify.UseVisualStyleBackColor = True
        '
        'chkTVIgnoreLastScan
        '
        Me.chkTVIgnoreLastScan.CheckAlign = System.Drawing.ContentAlignment.TopLeft
        Me.chkTVIgnoreLastScan.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkTVIgnoreLastScan.Location = New System.Drawing.Point(4, 68)
        Me.chkTVIgnoreLastScan.Name = "chkTVIgnoreLastScan"
        Me.chkTVIgnoreLastScan.Size = New System.Drawing.Size(142, 43)
        Me.chkTVIgnoreLastScan.TabIndex = 3
        Me.chkTVIgnoreLastScan.Text = "Ignore last scan time when updating library"
        Me.chkTVIgnoreLastScan.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.chkTVIgnoreLastScan.UseVisualStyleBackColor = True
        '
        'chkTVCleanDB
        '
        Me.chkTVCleanDB.CheckAlign = System.Drawing.ContentAlignment.TopLeft
        Me.chkTVCleanDB.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkTVCleanDB.Location = New System.Drawing.Point(4, 152)
        Me.chkTVCleanDB.Name = "chkTVCleanDB"
        Me.chkTVCleanDB.Size = New System.Drawing.Size(142, 43)
        Me.chkTVCleanDB.TabIndex = 5
        Me.chkTVCleanDB.Text = "Clean database after updating library"
        Me.chkTVCleanDB.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.chkTVCleanDB.UseVisualStyleBackColor = True
        '
        'btnAddTVSource
        '
        Me.btnAddTVSource.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.btnAddTVSource.Image = CType(resources.GetObject("btnAddTVSource.Image"), System.Drawing.Image)
        Me.btnAddTVSource.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAddTVSource.Location = New System.Drawing.Point(502, 4)
        Me.btnAddTVSource.Name = "btnAddTVSource"
        Me.btnAddTVSource.Size = New System.Drawing.Size(104, 23)
        Me.btnAddTVSource.TabIndex = 1
        Me.btnAddTVSource.Text = "Add Source"
        Me.btnAddTVSource.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAddTVSource.UseVisualStyleBackColor = True
        '
        'btnEditTVSource
        '
        Me.btnEditTVSource.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.btnEditTVSource.Image = CType(resources.GetObject("btnEditTVSource.Image"), System.Drawing.Image)
        Me.btnEditTVSource.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEditTVSource.Location = New System.Drawing.Point(502, 33)
        Me.btnEditTVSource.Name = "btnEditTVSource"
        Me.btnEditTVSource.Size = New System.Drawing.Size(104, 23)
        Me.btnEditTVSource.TabIndex = 2
        Me.btnEditTVSource.Text = "Edit Source"
        Me.btnEditTVSource.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEditTVSource.UseVisualStyleBackColor = True
        '
        'btnRemTVSource
        '
        Me.btnRemTVSource.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.btnRemTVSource.Image = CType(resources.GetObject("btnRemTVSource.Image"), System.Drawing.Image)
        Me.btnRemTVSource.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRemTVSource.Location = New System.Drawing.Point(502, 86)
        Me.btnRemTVSource.Name = "btnRemTVSource"
        Me.btnRemTVSource.Size = New System.Drawing.Size(104, 23)
        Me.btnRemTVSource.TabIndex = 3
        Me.btnRemTVSource.Text = "Remove"
        Me.btnRemTVSource.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnRemTVSource.UseVisualStyleBackColor = True
        '
        'gbTVNaming
        '
        Me.gbTVNaming.Controls.Add(Me.gbShowBanner)
        Me.gbTVNaming.Controls.Add(Me.gbAllSeasonPoster)
        Me.gbTVNaming.Controls.Add(Me.gbEpisodeFanart)
        Me.gbTVNaming.Controls.Add(Me.gbEpisodePosters)
        Me.gbTVNaming.Controls.Add(Me.gbSeasonFanart)
        Me.gbTVNaming.Controls.Add(Me.gbSeasonPosters)
        Me.gbTVNaming.Controls.Add(Me.gbShowFanart)
        Me.gbTVNaming.Controls.Add(Me.gbShowPosters)
        Me.gbTVNaming.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.gbTVNaming.Location = New System.Drawing.Point(161, 110)
        Me.gbTVNaming.Name = "gbTVNaming"
        Me.gbTVNaming.Size = New System.Drawing.Size(445, 253)
        Me.gbTVNaming.TabIndex = 6
        Me.gbTVNaming.TabStop = False
        Me.gbTVNaming.Text = "File Naming"
        '
        'gbShowBanner
        '
        Me.gbShowBanner.Controls.Add(Me.chkShowBannerJPG)
        Me.gbShowBanner.Enabled = False
        Me.gbShowBanner.Location = New System.Drawing.Point(5, 204)
        Me.gbShowBanner.Name = "gbShowBanner"
        Me.gbShowBanner.Size = New System.Drawing.Size(133, 40)
        Me.gbShowBanner.TabIndex = 2
        Me.gbShowBanner.TabStop = False
        Me.gbShowBanner.Text = "Show Banner"
        Me.gbShowBanner.Visible = False
        '
        'chkShowBannerJPG
        '
        Me.chkShowBannerJPG.AutoSize = True
        Me.chkShowBannerJPG.Enabled = False
        Me.chkShowBannerJPG.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.chkShowBannerJPG.Location = New System.Drawing.Point(6, 15)
        Me.chkShowBannerJPG.Name = "chkShowBannerJPG"
        Me.chkShowBannerJPG.Size = New System.Drawing.Size(83, 17)
        Me.chkShowBannerJPG.TabIndex = 0
        Me.chkShowBannerJPG.Text = "banner.jpg"
        Me.chkShowBannerJPG.UseVisualStyleBackColor = True
        Me.chkShowBannerJPG.Visible = False
        '
        'gbAllSeasonPoster
        '
        Me.gbAllSeasonPoster.Controls.Add(Me.chkSeasonAllPosterJPG)
        Me.gbAllSeasonPoster.Controls.Add(Me.chkSeasonAllJPG)
        Me.gbAllSeasonPoster.Controls.Add(Me.chkSeasonAllTBN)
        Me.gbAllSeasonPoster.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.gbAllSeasonPoster.Location = New System.Drawing.Point(292, 168)
        Me.gbAllSeasonPoster.Name = "gbAllSeasonPoster"
        Me.gbAllSeasonPoster.Size = New System.Drawing.Size(146, 81)
        Me.gbAllSeasonPoster.TabIndex = 7
        Me.gbAllSeasonPoster.TabStop = False
        Me.gbAllSeasonPoster.Text = "All Season Posters"
        '
        'chkSeasonAllPosterJPG
        '
        Me.chkSeasonAllPosterJPG.AutoSize = True
        Me.chkSeasonAllPosterJPG.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSeasonAllPosterJPG.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkSeasonAllPosterJPG.Location = New System.Drawing.Point(6, 49)
        Me.chkSeasonAllPosterJPG.Name = "chkSeasonAllPosterJPG"
        Me.chkSeasonAllPosterJPG.Size = New System.Drawing.Size(135, 17)
        Me.chkSeasonAllPosterJPG.TabIndex = 2
        Me.chkSeasonAllPosterJPG.Text = "season-all-poster.jpg"
        Me.chkSeasonAllPosterJPG.UseVisualStyleBackColor = True
        '
        'chkSeasonAllJPG
        '
        Me.chkSeasonAllJPG.AutoSize = True
        Me.chkSeasonAllJPG.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSeasonAllJPG.Location = New System.Drawing.Point(6, 34)
        Me.chkSeasonAllJPG.Name = "chkSeasonAllJPG"
        Me.chkSeasonAllJPG.Size = New System.Drawing.Size(98, 17)
        Me.chkSeasonAllJPG.TabIndex = 1
        Me.chkSeasonAllJPG.Text = "season-all.jpg"
        Me.chkSeasonAllJPG.UseVisualStyleBackColor = True
        '
        'chkSeasonAllTBN
        '
        Me.chkSeasonAllTBN.AutoSize = True
        Me.chkSeasonAllTBN.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSeasonAllTBN.Location = New System.Drawing.Point(6, 18)
        Me.chkSeasonAllTBN.Name = "chkSeasonAllTBN"
        Me.chkSeasonAllTBN.Size = New System.Drawing.Size(99, 17)
        Me.chkSeasonAllTBN.TabIndex = 0
        Me.chkSeasonAllTBN.Text = "season-all.tbn"
        Me.chkSeasonAllTBN.UseVisualStyleBackColor = True
        '
        'gbEpisodeFanart
        '
        Me.gbEpisodeFanart.Controls.Add(Me.chkEpisodeDotFanart)
        Me.gbEpisodeFanart.Controls.Add(Me.chkEpisodeDashFanart)
        Me.gbEpisodeFanart.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.gbEpisodeFanart.Location = New System.Drawing.Point(292, 97)
        Me.gbEpisodeFanart.Name = "gbEpisodeFanart"
        Me.gbEpisodeFanart.Size = New System.Drawing.Size(147, 52)
        Me.gbEpisodeFanart.TabIndex = 6
        Me.gbEpisodeFanart.TabStop = False
        Me.gbEpisodeFanart.Text = "Episode Fanart"
        '
        'chkEpisodeDotFanart
        '
        Me.chkEpisodeDotFanart.AutoSize = True
        Me.chkEpisodeDotFanart.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkEpisodeDotFanart.Location = New System.Drawing.Point(5, 31)
        Me.chkEpisodeDotFanart.Name = "chkEpisodeDotFanart"
        Me.chkEpisodeDotFanart.Size = New System.Drawing.Size(137, 17)
        Me.chkEpisodeDotFanart.TabIndex = 1
        Me.chkEpisodeDotFanart.Text = "<episode>.fanart.jpg"
        Me.chkEpisodeDotFanart.UseVisualStyleBackColor = True
        '
        'chkEpisodeDashFanart
        '
        Me.chkEpisodeDashFanart.AutoSize = True
        Me.chkEpisodeDashFanart.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkEpisodeDashFanart.Location = New System.Drawing.Point(5, 15)
        Me.chkEpisodeDashFanart.Name = "chkEpisodeDashFanart"
        Me.chkEpisodeDashFanart.Size = New System.Drawing.Size(138, 17)
        Me.chkEpisodeDashFanart.TabIndex = 0
        Me.chkEpisodeDashFanart.Text = "<episode>-fanart.jpg"
        Me.chkEpisodeDashFanart.UseVisualStyleBackColor = True
        '
        'gbEpisodePosters
        '
        Me.gbEpisodePosters.Controls.Add(Me.chkEpisodeDashThumbJPG)
        Me.gbEpisodePosters.Controls.Add(Me.chkEpisodeJPG)
        Me.gbEpisodePosters.Controls.Add(Me.chkEpisodeTBN)
        Me.gbEpisodePosters.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.gbEpisodePosters.Location = New System.Drawing.Point(292, 15)
        Me.gbEpisodePosters.Name = "gbEpisodePosters"
        Me.gbEpisodePosters.Size = New System.Drawing.Size(147, 74)
        Me.gbEpisodePosters.TabIndex = 5
        Me.gbEpisodePosters.TabStop = False
        Me.gbEpisodePosters.Text = "Episode Posters"
        '
        'chkEpisodeDashThumbJPG
        '
        Me.chkEpisodeDashThumbJPG.AutoSize = True
        Me.chkEpisodeDashThumbJPG.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkEpisodeDashThumbJPG.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkEpisodeDashThumbJPG.Location = New System.Drawing.Point(5, 49)
        Me.chkEpisodeDashThumbJPG.Name = "chkEpisodeDashThumbJPG"
        Me.chkEpisodeDashThumbJPG.Size = New System.Drawing.Size(141, 17)
        Me.chkEpisodeDashThumbJPG.TabIndex = 2
        Me.chkEpisodeDashThumbJPG.Text = "<episode>-thumb.jpg"
        Me.chkEpisodeDashThumbJPG.UseVisualStyleBackColor = True
        '
        'chkEpisodeJPG
        '
        Me.chkEpisodeJPG.AutoSize = True
        Me.chkEpisodeJPG.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkEpisodeJPG.Location = New System.Drawing.Point(5, 31)
        Me.chkEpisodeJPG.Name = "chkEpisodeJPG"
        Me.chkEpisodeJPG.Size = New System.Drawing.Size(103, 17)
        Me.chkEpisodeJPG.TabIndex = 1
        Me.chkEpisodeJPG.Text = "<episode>.jpg"
        Me.chkEpisodeJPG.UseVisualStyleBackColor = True
        '
        'chkEpisodeTBN
        '
        Me.chkEpisodeTBN.AutoSize = True
        Me.chkEpisodeTBN.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkEpisodeTBN.Location = New System.Drawing.Point(5, 15)
        Me.chkEpisodeTBN.Name = "chkEpisodeTBN"
        Me.chkEpisodeTBN.Size = New System.Drawing.Size(104, 17)
        Me.chkEpisodeTBN.TabIndex = 0
        Me.chkEpisodeTBN.Text = "<episode>.tbn"
        Me.chkEpisodeTBN.UseVisualStyleBackColor = True
        '
        'gbSeasonFanart
        '
        Me.gbSeasonFanart.Controls.Add(Me.chkSeasonXXDashFanartJPG)
        Me.gbSeasonFanart.Controls.Add(Me.chkSeasonDotFanart)
        Me.gbSeasonFanart.Controls.Add(Me.chkSeasonDashFanart)
        Me.gbSeasonFanart.Controls.Add(Me.chkSeasonFanartJPG)
        Me.gbSeasonFanart.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.gbSeasonFanart.Location = New System.Drawing.Point(143, 168)
        Me.gbSeasonFanart.Name = "gbSeasonFanart"
        Me.gbSeasonFanart.Size = New System.Drawing.Size(145, 81)
        Me.gbSeasonFanart.TabIndex = 4
        Me.gbSeasonFanart.TabStop = False
        Me.gbSeasonFanart.Text = "Season Fanart"
        '
        'chkSeasonXXDashFanartJPG
        '
        Me.chkSeasonXXDashFanartJPG.AutoSize = True
        Me.chkSeasonXXDashFanartJPG.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSeasonXXDashFanartJPG.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkSeasonXXDashFanartJPG.Location = New System.Drawing.Point(6, 62)
        Me.chkSeasonXXDashFanartJPG.Name = "chkSeasonXXDashFanartJPG"
        Me.chkSeasonXXDashFanartJPG.Size = New System.Drawing.Size(129, 17)
        Me.chkSeasonXXDashFanartJPG.TabIndex = 3
        Me.chkSeasonXXDashFanartJPG.Text = "seasonXX-fanart.jpg"
        Me.chkSeasonXXDashFanartJPG.UseVisualStyleBackColor = True
        '
        'chkSeasonDotFanart
        '
        Me.chkSeasonDotFanart.AutoSize = True
        Me.chkSeasonDotFanart.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSeasonDotFanart.Location = New System.Drawing.Point(6, 47)
        Me.chkSeasonDotFanart.Name = "chkSeasonDotFanart"
        Me.chkSeasonDotFanart.Size = New System.Drawing.Size(132, 17)
        Me.chkSeasonDotFanart.TabIndex = 2
        Me.chkSeasonDotFanart.Text = "<season>.fanart.jpg"
        Me.chkSeasonDotFanart.UseVisualStyleBackColor = True
        '
        'chkSeasonDashFanart
        '
        Me.chkSeasonDashFanart.AutoSize = True
        Me.chkSeasonDashFanart.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSeasonDashFanart.Location = New System.Drawing.Point(6, 31)
        Me.chkSeasonDashFanart.Name = "chkSeasonDashFanart"
        Me.chkSeasonDashFanart.Size = New System.Drawing.Size(133, 17)
        Me.chkSeasonDashFanart.TabIndex = 1
        Me.chkSeasonDashFanart.Text = "<season>-fanart.jpg"
        Me.chkSeasonDashFanart.UseVisualStyleBackColor = True
        '
        'chkSeasonFanartJPG
        '
        Me.chkSeasonFanartJPG.AutoSize = True
        Me.chkSeasonFanartJPG.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSeasonFanartJPG.Location = New System.Drawing.Point(6, 15)
        Me.chkSeasonFanartJPG.Name = "chkSeasonFanartJPG"
        Me.chkSeasonFanartJPG.Size = New System.Drawing.Size(77, 17)
        Me.chkSeasonFanartJPG.TabIndex = 0
        Me.chkSeasonFanartJPG.Text = "fanart.jpg"
        Me.chkSeasonFanartJPG.UseVisualStyleBackColor = True
        '
        'gbSeasonPosters
        '
        Me.gbSeasonPosters.Controls.Add(Me.chkSeasonXXDashPosterJPG)
        Me.gbSeasonPosters.Controls.Add(Me.chkSeasonFolderJPG)
        Me.gbSeasonPosters.Controls.Add(Me.chkSeasonNameJPG)
        Me.gbSeasonPosters.Controls.Add(Me.chkSeasonNameTBN)
        Me.gbSeasonPosters.Controls.Add(Me.chkSeasonPosterJPG)
        Me.gbSeasonPosters.Controls.Add(Me.chkSeasonPosterTBN)
        Me.gbSeasonPosters.Controls.Add(Me.chkSeasonXTBN)
        Me.gbSeasonPosters.Controls.Add(Me.chkSeasonXXTBN)
        Me.gbSeasonPosters.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.gbSeasonPosters.Location = New System.Drawing.Point(143, 15)
        Me.gbSeasonPosters.Name = "gbSeasonPosters"
        Me.gbSeasonPosters.Size = New System.Drawing.Size(145, 152)
        Me.gbSeasonPosters.TabIndex = 3
        Me.gbSeasonPosters.TabStop = False
        Me.gbSeasonPosters.Text = "Season Posters"
        '
        'chkSeasonXXDashPosterJPG
        '
        Me.chkSeasonXXDashPosterJPG.AutoSize = True
        Me.chkSeasonXXDashPosterJPG.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSeasonXXDashPosterJPG.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkSeasonXXDashPosterJPG.Location = New System.Drawing.Point(6, 48)
        Me.chkSeasonXXDashPosterJPG.Name = "chkSeasonXXDashPosterJPG"
        Me.chkSeasonXXDashPosterJPG.Size = New System.Drawing.Size(131, 17)
        Me.chkSeasonXXDashPosterJPG.TabIndex = 2
        Me.chkSeasonXXDashPosterJPG.Text = "seasonXX-poster.jpg"
        Me.chkSeasonXXDashPosterJPG.UseVisualStyleBackColor = True
        '
        'chkSeasonFolderJPG
        '
        Me.chkSeasonFolderJPG.AutoSize = True
        Me.chkSeasonFolderJPG.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSeasonFolderJPG.Location = New System.Drawing.Point(6, 129)
        Me.chkSeasonFolderJPG.Name = "chkSeasonFolderJPG"
        Me.chkSeasonFolderJPG.Size = New System.Drawing.Size(77, 17)
        Me.chkSeasonFolderJPG.TabIndex = 7
        Me.chkSeasonFolderJPG.Text = "folder.jpg"
        Me.chkSeasonFolderJPG.UseVisualStyleBackColor = True
        '
        'chkSeasonNameJPG
        '
        Me.chkSeasonNameJPG.AutoSize = True
        Me.chkSeasonNameJPG.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSeasonNameJPG.Location = New System.Drawing.Point(6, 113)
        Me.chkSeasonNameJPG.Name = "chkSeasonNameJPG"
        Me.chkSeasonNameJPG.Size = New System.Drawing.Size(98, 17)
        Me.chkSeasonNameJPG.TabIndex = 6
        Me.chkSeasonNameJPG.Text = "<season>.jpg"
        Me.chkSeasonNameJPG.UseVisualStyleBackColor = True
        '
        'chkSeasonNameTBN
        '
        Me.chkSeasonNameTBN.AutoSize = True
        Me.chkSeasonNameTBN.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSeasonNameTBN.Location = New System.Drawing.Point(6, 97)
        Me.chkSeasonNameTBN.Name = "chkSeasonNameTBN"
        Me.chkSeasonNameTBN.Size = New System.Drawing.Size(99, 17)
        Me.chkSeasonNameTBN.TabIndex = 5
        Me.chkSeasonNameTBN.Text = "<season>.tbn"
        Me.chkSeasonNameTBN.UseVisualStyleBackColor = True
        '
        'chkSeasonPosterJPG
        '
        Me.chkSeasonPosterJPG.AutoSize = True
        Me.chkSeasonPosterJPG.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSeasonPosterJPG.Location = New System.Drawing.Point(6, 81)
        Me.chkSeasonPosterJPG.Name = "chkSeasonPosterJPG"
        Me.chkSeasonPosterJPG.Size = New System.Drawing.Size(79, 17)
        Me.chkSeasonPosterJPG.TabIndex = 4
        Me.chkSeasonPosterJPG.Text = "poster.jpg"
        Me.chkSeasonPosterJPG.UseVisualStyleBackColor = True
        '
        'chkSeasonPosterTBN
        '
        Me.chkSeasonPosterTBN.AutoSize = True
        Me.chkSeasonPosterTBN.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSeasonPosterTBN.Location = New System.Drawing.Point(6, 65)
        Me.chkSeasonPosterTBN.Name = "chkSeasonPosterTBN"
        Me.chkSeasonPosterTBN.Size = New System.Drawing.Size(80, 17)
        Me.chkSeasonPosterTBN.TabIndex = 3
        Me.chkSeasonPosterTBN.Text = "poster.tbn"
        Me.chkSeasonPosterTBN.UseVisualStyleBackColor = True
        '
        'chkSeasonXTBN
        '
        Me.chkSeasonXTBN.AutoSize = True
        Me.chkSeasonXTBN.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSeasonXTBN.Location = New System.Drawing.Point(6, 31)
        Me.chkSeasonXTBN.Name = "chkSeasonXTBN"
        Me.chkSeasonXTBN.Size = New System.Drawing.Size(89, 17)
        Me.chkSeasonXTBN.TabIndex = 1
        Me.chkSeasonXTBN.Text = "seasonX.tbn"
        Me.chkSeasonXTBN.UseVisualStyleBackColor = True
        '
        'chkSeasonXXTBN
        '
        Me.chkSeasonXXTBN.AutoSize = True
        Me.chkSeasonXXTBN.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSeasonXXTBN.Location = New System.Drawing.Point(6, 15)
        Me.chkSeasonXXTBN.Name = "chkSeasonXXTBN"
        Me.chkSeasonXXTBN.Size = New System.Drawing.Size(95, 17)
        Me.chkSeasonXXTBN.TabIndex = 0
        Me.chkSeasonXXTBN.Text = "seasonXX.tbn"
        Me.chkSeasonXXTBN.UseVisualStyleBackColor = True
        '
        'gbShowFanart
        '
        Me.gbShowFanart.Controls.Add(Me.chkShowDotFanart)
        Me.gbShowFanart.Controls.Add(Me.chkShowDashFanart)
        Me.gbShowFanart.Controls.Add(Me.chkShowFanartJPG)
        Me.gbShowFanart.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.gbShowFanart.Location = New System.Drawing.Point(5, 120)
        Me.gbShowFanart.Name = "gbShowFanart"
        Me.gbShowFanart.Size = New System.Drawing.Size(133, 70)
        Me.gbShowFanart.TabIndex = 1
        Me.gbShowFanart.TabStop = False
        Me.gbShowFanart.Text = "Show Fanart"
        '
        'chkShowDotFanart
        '
        Me.chkShowDotFanart.AutoSize = True
        Me.chkShowDotFanart.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkShowDotFanart.Location = New System.Drawing.Point(6, 51)
        Me.chkShowDotFanart.Name = "chkShowDotFanart"
        Me.chkShowDotFanart.Size = New System.Drawing.Size(124, 17)
        Me.chkShowDotFanart.TabIndex = 2
        Me.chkShowDotFanart.Text = "<show>.fanart.jpg"
        Me.chkShowDotFanart.UseVisualStyleBackColor = True
        '
        'chkShowDashFanart
        '
        Me.chkShowDashFanart.AutoSize = True
        Me.chkShowDashFanart.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkShowDashFanart.Location = New System.Drawing.Point(6, 35)
        Me.chkShowDashFanart.Name = "chkShowDashFanart"
        Me.chkShowDashFanart.Size = New System.Drawing.Size(125, 17)
        Me.chkShowDashFanart.TabIndex = 1
        Me.chkShowDashFanart.Text = "<show>-fanart.jpg"
        Me.chkShowDashFanart.UseVisualStyleBackColor = True
        '
        'chkShowFanartJPG
        '
        Me.chkShowFanartJPG.AutoSize = True
        Me.chkShowFanartJPG.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkShowFanartJPG.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkShowFanartJPG.Location = New System.Drawing.Point(6, 19)
        Me.chkShowFanartJPG.Name = "chkShowFanartJPG"
        Me.chkShowFanartJPG.Size = New System.Drawing.Size(77, 17)
        Me.chkShowFanartJPG.TabIndex = 0
        Me.chkShowFanartJPG.Text = "fanart.jpg"
        Me.chkShowFanartJPG.UseVisualStyleBackColor = True
        '
        'gbShowPosters
        '
        Me.gbShowPosters.Controls.Add(Me.chkShowJPG)
        Me.gbShowPosters.Controls.Add(Me.chkShowTBN)
        Me.gbShowPosters.Controls.Add(Me.chkShowPosterJPG)
        Me.gbShowPosters.Controls.Add(Me.chkShowPosterTBN)
        Me.gbShowPosters.Controls.Add(Me.chkShowFolderJPG)
        Me.gbShowPosters.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.gbShowPosters.Location = New System.Drawing.Point(5, 15)
        Me.gbShowPosters.Name = "gbShowPosters"
        Me.gbShowPosters.Size = New System.Drawing.Size(133, 99)
        Me.gbShowPosters.TabIndex = 0
        Me.gbShowPosters.TabStop = False
        Me.gbShowPosters.Text = "Show Posters"
        '
        'chkShowJPG
        '
        Me.chkShowJPG.AutoSize = True
        Me.chkShowJPG.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkShowJPG.Location = New System.Drawing.Point(6, 32)
        Me.chkShowJPG.Name = "chkShowJPG"
        Me.chkShowJPG.Size = New System.Drawing.Size(90, 17)
        Me.chkShowJPG.TabIndex = 1
        Me.chkShowJPG.Text = "<show>.jpg"
        Me.chkShowJPG.UseVisualStyleBackColor = True
        '
        'chkShowTBN
        '
        Me.chkShowTBN.AutoSize = True
        Me.chkShowTBN.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkShowTBN.Location = New System.Drawing.Point(6, 16)
        Me.chkShowTBN.Name = "chkShowTBN"
        Me.chkShowTBN.Size = New System.Drawing.Size(91, 17)
        Me.chkShowTBN.TabIndex = 0
        Me.chkShowTBN.Text = "<show>.tbn"
        Me.chkShowTBN.UseVisualStyleBackColor = True
        '
        'chkShowPosterJPG
        '
        Me.chkShowPosterJPG.AutoSize = True
        Me.chkShowPosterJPG.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkShowPosterJPG.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkShowPosterJPG.Location = New System.Drawing.Point(6, 64)
        Me.chkShowPosterJPG.Name = "chkShowPosterJPG"
        Me.chkShowPosterJPG.Size = New System.Drawing.Size(79, 17)
        Me.chkShowPosterJPG.TabIndex = 3
        Me.chkShowPosterJPG.Text = "poster.jpg"
        Me.chkShowPosterJPG.UseVisualStyleBackColor = True
        '
        'chkShowPosterTBN
        '
        Me.chkShowPosterTBN.AutoSize = True
        Me.chkShowPosterTBN.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkShowPosterTBN.Location = New System.Drawing.Point(6, 48)
        Me.chkShowPosterTBN.Name = "chkShowPosterTBN"
        Me.chkShowPosterTBN.Size = New System.Drawing.Size(80, 17)
        Me.chkShowPosterTBN.TabIndex = 2
        Me.chkShowPosterTBN.Text = "poster.tbn"
        Me.chkShowPosterTBN.UseVisualStyleBackColor = True
        '
        'chkShowFolderJPG
        '
        Me.chkShowFolderJPG.AutoSize = True
        Me.chkShowFolderJPG.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkShowFolderJPG.Location = New System.Drawing.Point(6, 80)
        Me.chkShowFolderJPG.Name = "chkShowFolderJPG"
        Me.chkShowFolderJPG.Size = New System.Drawing.Size(77, 17)
        Me.chkShowFolderJPG.TabIndex = 4
        Me.chkShowFolderJPG.Text = "folder.jpg"
        Me.chkShowFolderJPG.UseVisualStyleBackColor = True
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.btnGetTVProfiles)
        Me.TabPage4.Controls.Add(Me.btnRegexDown)
        Me.TabPage4.Controls.Add(Me.btnRegexUp)
        Me.TabPage4.Controls.Add(Me.btnResetShowRegex)
        Me.TabPage4.Controls.Add(Me.gbShowRegex)
        Me.TabPage4.Controls.Add(Me.btnEditShowRegex)
        Me.TabPage4.Controls.Add(Me.btnRemoveShowRegex)
        Me.TabPage4.Controls.Add(Me.lvShowRegex)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(612, 374)
        Me.TabPage4.TabIndex = 1
        Me.TabPage4.Text = "Regex"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'btnGetTVProfiles
        '
        Me.btnGetTVProfiles.Image = CType(resources.GetObject("btnGetTVProfiles.Image"), System.Drawing.Image)
        Me.btnGetTVProfiles.Location = New System.Drawing.Point(550, 3)
        Me.btnGetTVProfiles.Name = "btnGetTVProfiles"
        Me.btnGetTVProfiles.Size = New System.Drawing.Size(23, 23)
        Me.btnGetTVProfiles.TabIndex = 1
        Me.btnGetTVProfiles.UseVisualStyleBackColor = True
        '
        'btnRegexDown
        '
        Me.btnRegexDown.Image = CType(resources.GetObject("btnRegexDown.Image"), System.Drawing.Image)
        Me.btnRegexDown.Location = New System.Drawing.Point(304, 167)
        Me.btnRegexDown.Name = "btnRegexDown"
        Me.btnRegexDown.Size = New System.Drawing.Size(23, 23)
        Me.btnRegexDown.TabIndex = 5
        Me.btnRegexDown.UseVisualStyleBackColor = True
        '
        'btnRegexUp
        '
        Me.btnRegexUp.Image = CType(resources.GetObject("btnRegexUp.Image"), System.Drawing.Image)
        Me.btnRegexUp.Location = New System.Drawing.Point(280, 167)
        Me.btnRegexUp.Name = "btnRegexUp"
        Me.btnRegexUp.Size = New System.Drawing.Size(23, 23)
        Me.btnRegexUp.TabIndex = 4
        Me.btnRegexUp.UseVisualStyleBackColor = True
        '
        'btnResetShowRegex
        '
        Me.btnResetShowRegex.Image = CType(resources.GetObject("btnResetShowRegex.Image"), System.Drawing.Image)
        Me.btnResetShowRegex.Location = New System.Drawing.Point(576, 3)
        Me.btnResetShowRegex.Name = "btnResetShowRegex"
        Me.btnResetShowRegex.Size = New System.Drawing.Size(23, 23)
        Me.btnResetShowRegex.TabIndex = 2
        Me.btnResetShowRegex.UseVisualStyleBackColor = True
        '
        'gbShowRegex
        '
        Me.gbShowRegex.Controls.Add(Me.btnClearRegex)
        Me.gbShowRegex.Controls.Add(Me.lblSeasonMatch)
        Me.gbShowRegex.Controls.Add(Me.btnAddShowRegex)
        Me.gbShowRegex.Controls.Add(Me.txtSeasonRegex)
        Me.gbShowRegex.Controls.Add(Me.lblEpisodeRetrieve)
        Me.gbShowRegex.Controls.Add(Me.cboSeasonRetrieve)
        Me.gbShowRegex.Controls.Add(Me.lblSeasonRetrieve)
        Me.gbShowRegex.Controls.Add(Me.txtEpRegex)
        Me.gbShowRegex.Controls.Add(Me.lblEpisodeMatch)
        Me.gbShowRegex.Controls.Add(Me.cboEpRetrieve)
        Me.gbShowRegex.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbShowRegex.Location = New System.Drawing.Point(6, 196)
        Me.gbShowRegex.Name = "gbShowRegex"
        Me.gbShowRegex.Size = New System.Drawing.Size(592, 148)
        Me.gbShowRegex.TabIndex = 7
        Me.gbShowRegex.TabStop = False
        Me.gbShowRegex.Text = "Show Match Regex"
        '
        'btnClearRegex
        '
        Me.btnClearRegex.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.btnClearRegex.Image = CType(resources.GetObject("btnClearRegex.Image"), System.Drawing.Image)
        Me.btnClearRegex.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClearRegex.Location = New System.Drawing.Point(10, 116)
        Me.btnClearRegex.Name = "btnClearRegex"
        Me.btnClearRegex.Size = New System.Drawing.Size(104, 23)
        Me.btnClearRegex.TabIndex = 8
        Me.btnClearRegex.Text = "Clear"
        Me.btnClearRegex.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnClearRegex.UseVisualStyleBackColor = True
        '
        'lblSeasonMatch
        '
        Me.lblSeasonMatch.AutoSize = True
        Me.lblSeasonMatch.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSeasonMatch.Location = New System.Drawing.Point(8, 25)
        Me.lblSeasonMatch.Name = "lblSeasonMatch"
        Me.lblSeasonMatch.Size = New System.Drawing.Size(116, 13)
        Me.lblSeasonMatch.TabIndex = 0
        Me.lblSeasonMatch.Text = "Season Match Regex:"
        '
        'btnAddShowRegex
        '
        Me.btnAddShowRegex.Enabled = False
        Me.btnAddShowRegex.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.btnAddShowRegex.Image = CType(resources.GetObject("btnAddShowRegex.Image"), System.Drawing.Image)
        Me.btnAddShowRegex.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAddShowRegex.Location = New System.Drawing.Point(482, 117)
        Me.btnAddShowRegex.Name = "btnAddShowRegex"
        Me.btnAddShowRegex.Size = New System.Drawing.Size(104, 23)
        Me.btnAddShowRegex.TabIndex = 9
        Me.btnAddShowRegex.Text = "Add Regex"
        Me.btnAddShowRegex.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAddShowRegex.UseVisualStyleBackColor = True
        '
        'txtSeasonRegex
        '
        Me.txtSeasonRegex.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSeasonRegex.Location = New System.Drawing.Point(10, 40)
        Me.txtSeasonRegex.Name = "txtSeasonRegex"
        Me.txtSeasonRegex.Size = New System.Drawing.Size(417, 22)
        Me.txtSeasonRegex.TabIndex = 1
        '
        'lblEpisodeRetrieve
        '
        Me.lblEpisodeRetrieve.AutoSize = True
        Me.lblEpisodeRetrieve.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEpisodeRetrieve.Location = New System.Drawing.Point(441, 69)
        Me.lblEpisodeRetrieve.Name = "lblEpisodeRetrieve"
        Me.lblEpisodeRetrieve.Size = New System.Drawing.Size(54, 13)
        Me.lblEpisodeRetrieve.TabIndex = 6
        Me.lblEpisodeRetrieve.Text = "Apply To:"
        '
        'cboSeasonRetrieve
        '
        Me.cboSeasonRetrieve.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSeasonRetrieve.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSeasonRetrieve.FormattingEnabled = True
        Me.cboSeasonRetrieve.Items.AddRange(New Object() {"Folder Name", "File Name"})
        Me.cboSeasonRetrieve.Location = New System.Drawing.Point(443, 40)
        Me.cboSeasonRetrieve.Name = "cboSeasonRetrieve"
        Me.cboSeasonRetrieve.Size = New System.Drawing.Size(135, 21)
        Me.cboSeasonRetrieve.TabIndex = 3
        '
        'lblSeasonRetrieve
        '
        Me.lblSeasonRetrieve.AutoSize = True
        Me.lblSeasonRetrieve.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSeasonRetrieve.Location = New System.Drawing.Point(441, 25)
        Me.lblSeasonRetrieve.Name = "lblSeasonRetrieve"
        Me.lblSeasonRetrieve.Size = New System.Drawing.Size(54, 13)
        Me.lblSeasonRetrieve.TabIndex = 2
        Me.lblSeasonRetrieve.Text = "Apply To:"
        '
        'txtEpRegex
        '
        Me.txtEpRegex.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEpRegex.Location = New System.Drawing.Point(10, 84)
        Me.txtEpRegex.Name = "txtEpRegex"
        Me.txtEpRegex.Size = New System.Drawing.Size(417, 22)
        Me.txtEpRegex.TabIndex = 5
        '
        'lblEpisodeMatch
        '
        Me.lblEpisodeMatch.AutoSize = True
        Me.lblEpisodeMatch.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEpisodeMatch.Location = New System.Drawing.Point(8, 69)
        Me.lblEpisodeMatch.Name = "lblEpisodeMatch"
        Me.lblEpisodeMatch.Size = New System.Drawing.Size(120, 13)
        Me.lblEpisodeMatch.TabIndex = 4
        Me.lblEpisodeMatch.Text = "Episode Match Regex:"
        '
        'cboEpRetrieve
        '
        Me.cboEpRetrieve.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboEpRetrieve.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboEpRetrieve.FormattingEnabled = True
        Me.cboEpRetrieve.Items.AddRange(New Object() {"Folder Name", "File Name", "Season Result"})
        Me.cboEpRetrieve.Location = New System.Drawing.Point(443, 84)
        Me.cboEpRetrieve.Name = "cboEpRetrieve"
        Me.cboEpRetrieve.Size = New System.Drawing.Size(135, 21)
        Me.cboEpRetrieve.TabIndex = 7
        '
        'btnEditShowRegex
        '
        Me.btnEditShowRegex.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.btnEditShowRegex.Image = CType(resources.GetObject("btnEditShowRegex.Image"), System.Drawing.Image)
        Me.btnEditShowRegex.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEditShowRegex.Location = New System.Drawing.Point(1, 167)
        Me.btnEditShowRegex.Name = "btnEditShowRegex"
        Me.btnEditShowRegex.Size = New System.Drawing.Size(104, 23)
        Me.btnEditShowRegex.TabIndex = 3
        Me.btnEditShowRegex.Text = "Edit Regex"
        Me.btnEditShowRegex.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEditShowRegex.UseVisualStyleBackColor = True
        '
        'btnRemoveShowRegex
        '
        Me.btnRemoveShowRegex.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.btnRemoveShowRegex.Image = CType(resources.GetObject("btnRemoveShowRegex.Image"), System.Drawing.Image)
        Me.btnRemoveShowRegex.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRemoveShowRegex.Location = New System.Drawing.Point(494, 167)
        Me.btnRemoveShowRegex.Name = "btnRemoveShowRegex"
        Me.btnRemoveShowRegex.Size = New System.Drawing.Size(104, 23)
        Me.btnRemoveShowRegex.TabIndex = 6
        Me.btnRemoveShowRegex.Text = "Remove"
        Me.btnRemoveShowRegex.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnRemoveShowRegex.UseVisualStyleBackColor = True
        '
        'lvShowRegex
        '
        Me.lvShowRegex.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colRegID, Me.colSeason, Me.colSeasonApply, Me.colEpisode, Me.colEpApply})
        Me.lvShowRegex.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lvShowRegex.FullRowSelect = True
        Me.lvShowRegex.HideSelection = False
        Me.lvShowRegex.Location = New System.Drawing.Point(0, 28)
        Me.lvShowRegex.Name = "lvShowRegex"
        Me.lvShowRegex.Size = New System.Drawing.Size(598, 135)
        Me.lvShowRegex.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.lvShowRegex.TabIndex = 0
        Me.lvShowRegex.UseCompatibleStateImageBehavior = False
        Me.lvShowRegex.View = System.Windows.Forms.View.Details
        '
        'colRegID
        '
        Me.colRegID.DisplayIndex = 4
        Me.colRegID.Width = 0
        '
        'colSeason
        '
        Me.colSeason.DisplayIndex = 0
        Me.colSeason.Text = "Season Regex"
        Me.colSeason.Width = 224
        '
        'colSeasonApply
        '
        Me.colSeasonApply.DisplayIndex = 1
        Me.colSeasonApply.Text = "Apply To"
        Me.colSeasonApply.Width = 70
        '
        'colEpisode
        '
        Me.colEpisode.DisplayIndex = 2
        Me.colEpisode.Text = "Episode Regex"
        Me.colEpisode.Width = 219
        '
        'colEpApply
        '
        Me.colEpApply.DisplayIndex = 3
        Me.colEpApply.Text = "Apply To"
        Me.colEpApply.Width = 70
        '
        'pnlShows
        '
        Me.pnlShows.BackColor = System.Drawing.Color.White
        Me.pnlShows.Controls.Add(Me.gbShowMediaList)
        Me.pnlShows.Controls.Add(Me.gbShowsMiscellaneous)
        Me.pnlShows.Controls.Add(Me.gbShowEpFilter)
        Me.pnlShows.Controls.Add(Me.gbShowFilter)
        Me.pnlShows.Location = New System.Drawing.Point(900, 900)
        Me.pnlShows.Name = "pnlShows"
        Me.pnlShows.Size = New System.Drawing.Size(635, 435)
        Me.pnlShows.TabIndex = 20
        Me.pnlShows.Visible = False
        '
        'gbShowMediaList
        '
        Me.gbShowMediaList.Controls.Add(Me.chkDisplayMissingEpisodes)
        Me.gbShowMediaList.Controls.Add(Me.gbEpisodeListOptions)
        Me.gbShowMediaList.Controls.Add(Me.gbSeasonListOptions)
        Me.gbShowMediaList.Controls.Add(Me.gbShowListOptions)
        Me.gbShowMediaList.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.gbShowMediaList.Location = New System.Drawing.Point(6, 150)
        Me.gbShowMediaList.Name = "gbShowMediaList"
        Me.gbShowMediaList.Size = New System.Drawing.Size(219, 258)
        Me.gbShowMediaList.TabIndex = 1
        Me.gbShowMediaList.TabStop = False
        Me.gbShowMediaList.Text = "Media List Options"
        '
        'chkDisplayMissingEpisodes
        '
        Me.chkDisplayMissingEpisodes.AutoSize = True
        Me.chkDisplayMissingEpisodes.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkDisplayMissingEpisodes.Location = New System.Drawing.Point(8, 234)
        Me.chkDisplayMissingEpisodes.Name = "chkDisplayMissingEpisodes"
        Me.chkDisplayMissingEpisodes.Size = New System.Drawing.Size(155, 17)
        Me.chkDisplayMissingEpisodes.TabIndex = 3
        Me.chkDisplayMissingEpisodes.Text = "Display Missing Episodes"
        Me.chkDisplayMissingEpisodes.UseVisualStyleBackColor = True
        '
        'gbEpisodeListOptions
        '
        Me.gbEpisodeListOptions.Controls.Add(Me.chkEpisodeWatchedCol)
        Me.gbEpisodeListOptions.Controls.Add(Me.chkEpisodeNfoCol)
        Me.gbEpisodeListOptions.Controls.Add(Me.chkEpisodeFanartCol)
        Me.gbEpisodeListOptions.Controls.Add(Me.chkEpisodePosterCol)
        Me.gbEpisodeListOptions.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.gbEpisodeListOptions.Location = New System.Drawing.Point(10, 143)
        Me.gbEpisodeListOptions.Name = "gbEpisodeListOptions"
        Me.gbEpisodeListOptions.Size = New System.Drawing.Size(199, 86)
        Me.gbEpisodeListOptions.TabIndex = 2
        Me.gbEpisodeListOptions.TabStop = False
        Me.gbEpisodeListOptions.Text = "Episodes"
        '
        'chkEpisodeWatchedCol
        '
        Me.chkEpisodeWatchedCol.AutoSize = True
        Me.chkEpisodeWatchedCol.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkEpisodeWatchedCol.Location = New System.Drawing.Point(7, 64)
        Me.chkEpisodeWatchedCol.Name = "chkEpisodeWatchedCol"
        Me.chkEpisodeWatchedCol.Size = New System.Drawing.Size(142, 17)
        Me.chkEpisodeWatchedCol.TabIndex = 3
        Me.chkEpisodeWatchedCol.Text = "Hide Watched Column"
        Me.chkEpisodeWatchedCol.UseVisualStyleBackColor = True
        '
        'chkEpisodeNfoCol
        '
        Me.chkEpisodeNfoCol.AutoSize = True
        Me.chkEpisodeNfoCol.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkEpisodeNfoCol.Location = New System.Drawing.Point(7, 48)
        Me.chkEpisodeNfoCol.Name = "chkEpisodeNfoCol"
        Me.chkEpisodeNfoCol.Size = New System.Drawing.Size(117, 17)
        Me.chkEpisodeNfoCol.TabIndex = 2
        Me.chkEpisodeNfoCol.Text = "Hide Info Column"
        Me.chkEpisodeNfoCol.UseVisualStyleBackColor = True
        '
        'chkEpisodeFanartCol
        '
        Me.chkEpisodeFanartCol.AutoSize = True
        Me.chkEpisodeFanartCol.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkEpisodeFanartCol.Location = New System.Drawing.Point(7, 32)
        Me.chkEpisodeFanartCol.Name = "chkEpisodeFanartCol"
        Me.chkEpisodeFanartCol.Size = New System.Drawing.Size(129, 17)
        Me.chkEpisodeFanartCol.TabIndex = 1
        Me.chkEpisodeFanartCol.Text = "Hide Fanart Column"
        Me.chkEpisodeFanartCol.UseVisualStyleBackColor = True
        '
        'chkEpisodePosterCol
        '
        Me.chkEpisodePosterCol.AutoSize = True
        Me.chkEpisodePosterCol.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkEpisodePosterCol.Location = New System.Drawing.Point(7, 16)
        Me.chkEpisodePosterCol.Name = "chkEpisodePosterCol"
        Me.chkEpisodePosterCol.Size = New System.Drawing.Size(128, 17)
        Me.chkEpisodePosterCol.TabIndex = 0
        Me.chkEpisodePosterCol.Text = "Hide Poster Column"
        Me.chkEpisodePosterCol.UseVisualStyleBackColor = True
        '
        'gbSeasonListOptions
        '
        Me.gbSeasonListOptions.Controls.Add(Me.chkSeasonFanartCol)
        Me.gbSeasonListOptions.Controls.Add(Me.chkSeasonPosterCol)
        Me.gbSeasonListOptions.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.gbSeasonListOptions.Location = New System.Drawing.Point(10, 87)
        Me.gbSeasonListOptions.Name = "gbSeasonListOptions"
        Me.gbSeasonListOptions.Size = New System.Drawing.Size(199, 52)
        Me.gbSeasonListOptions.TabIndex = 1
        Me.gbSeasonListOptions.TabStop = False
        Me.gbSeasonListOptions.Text = "Seasons"
        '
        'chkSeasonFanartCol
        '
        Me.chkSeasonFanartCol.AutoSize = True
        Me.chkSeasonFanartCol.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSeasonFanartCol.Location = New System.Drawing.Point(7, 32)
        Me.chkSeasonFanartCol.Name = "chkSeasonFanartCol"
        Me.chkSeasonFanartCol.Size = New System.Drawing.Size(129, 17)
        Me.chkSeasonFanartCol.TabIndex = 1
        Me.chkSeasonFanartCol.Text = "Hide Fanart Column"
        Me.chkSeasonFanartCol.UseVisualStyleBackColor = True
        '
        'chkSeasonPosterCol
        '
        Me.chkSeasonPosterCol.AutoSize = True
        Me.chkSeasonPosterCol.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSeasonPosterCol.Location = New System.Drawing.Point(7, 16)
        Me.chkSeasonPosterCol.Name = "chkSeasonPosterCol"
        Me.chkSeasonPosterCol.Size = New System.Drawing.Size(128, 17)
        Me.chkSeasonPosterCol.TabIndex = 0
        Me.chkSeasonPosterCol.Text = "Hide Poster Column"
        Me.chkSeasonPosterCol.UseVisualStyleBackColor = True
        '
        'gbShowListOptions
        '
        Me.gbShowListOptions.Controls.Add(Me.chkShowNfoCol)
        Me.gbShowListOptions.Controls.Add(Me.chkShowFanartCol)
        Me.gbShowListOptions.Controls.Add(Me.chkShowPosterCol)
        Me.gbShowListOptions.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.gbShowListOptions.Location = New System.Drawing.Point(9, 16)
        Me.gbShowListOptions.Name = "gbShowListOptions"
        Me.gbShowListOptions.Size = New System.Drawing.Size(199, 68)
        Me.gbShowListOptions.TabIndex = 0
        Me.gbShowListOptions.TabStop = False
        Me.gbShowListOptions.Text = "Shows"
        '
        'chkShowNfoCol
        '
        Me.chkShowNfoCol.AutoSize = True
        Me.chkShowNfoCol.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkShowNfoCol.Location = New System.Drawing.Point(7, 48)
        Me.chkShowNfoCol.Name = "chkShowNfoCol"
        Me.chkShowNfoCol.Size = New System.Drawing.Size(117, 17)
        Me.chkShowNfoCol.TabIndex = 2
        Me.chkShowNfoCol.Text = "Hide Info Column"
        Me.chkShowNfoCol.UseVisualStyleBackColor = True
        '
        'chkShowFanartCol
        '
        Me.chkShowFanartCol.AutoSize = True
        Me.chkShowFanartCol.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkShowFanartCol.Location = New System.Drawing.Point(7, 32)
        Me.chkShowFanartCol.Name = "chkShowFanartCol"
        Me.chkShowFanartCol.Size = New System.Drawing.Size(129, 17)
        Me.chkShowFanartCol.TabIndex = 1
        Me.chkShowFanartCol.Text = "Hide Fanart Column"
        Me.chkShowFanartCol.UseVisualStyleBackColor = True
        '
        'chkShowPosterCol
        '
        Me.chkShowPosterCol.AutoSize = True
        Me.chkShowPosterCol.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkShowPosterCol.Location = New System.Drawing.Point(7, 16)
        Me.chkShowPosterCol.Name = "chkShowPosterCol"
        Me.chkShowPosterCol.Size = New System.Drawing.Size(128, 17)
        Me.chkShowPosterCol.TabIndex = 0
        Me.chkShowPosterCol.Text = "Hide Poster Column"
        Me.chkShowPosterCol.UseVisualStyleBackColor = True
        '
        'gbShowsMiscellaneous
        '
        Me.gbShowsMiscellaneous.Controls.Add(Me.chkMarkNewShows)
        Me.gbShowsMiscellaneous.Controls.Add(Me.chkMarkNewEpisodes)
        Me.gbShowsMiscellaneous.Controls.Add(Me.chkDisplayAllSeason)
        Me.gbShowsMiscellaneous.Controls.Add(Me.lblRatingRegion)
        Me.gbShowsMiscellaneous.Controls.Add(Me.cbRatingRegion)
        Me.gbShowsMiscellaneous.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.gbShowsMiscellaneous.Location = New System.Drawing.Point(6, 7)
        Me.gbShowsMiscellaneous.Name = "gbShowsMiscellaneous"
        Me.gbShowsMiscellaneous.Size = New System.Drawing.Size(219, 137)
        Me.gbShowsMiscellaneous.TabIndex = 0
        Me.gbShowsMiscellaneous.TabStop = False
        Me.gbShowsMiscellaneous.Text = "Miscellaneous"
        '
        'chkMarkNewShows
        '
        Me.chkMarkNewShows.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkMarkNewShows.Location = New System.Drawing.Point(8, 90)
        Me.chkMarkNewShows.Name = "chkMarkNewShows"
        Me.chkMarkNewShows.Size = New System.Drawing.Size(204, 17)
        Me.chkMarkNewShows.TabIndex = 3
        Me.chkMarkNewShows.Text = "Mark New Shows"
        Me.chkMarkNewShows.UseVisualStyleBackColor = True
        '
        'chkMarkNewEpisodes
        '
        Me.chkMarkNewEpisodes.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkMarkNewEpisodes.Location = New System.Drawing.Point(8, 113)
        Me.chkMarkNewEpisodes.Name = "chkMarkNewEpisodes"
        Me.chkMarkNewEpisodes.Size = New System.Drawing.Size(204, 17)
        Me.chkMarkNewEpisodes.TabIndex = 4
        Me.chkMarkNewEpisodes.Text = "Mark New Episodes"
        Me.chkMarkNewEpisodes.UseVisualStyleBackColor = True
        '
        'chkDisplayAllSeason
        '
        Me.chkDisplayAllSeason.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkDisplayAllSeason.Location = New System.Drawing.Point(8, 67)
        Me.chkDisplayAllSeason.Name = "chkDisplayAllSeason"
        Me.chkDisplayAllSeason.Size = New System.Drawing.Size(204, 17)
        Me.chkDisplayAllSeason.TabIndex = 2
        Me.chkDisplayAllSeason.Text = "Display All Season Poster"
        Me.chkDisplayAllSeason.UseVisualStyleBackColor = True
        '
        'lblRatingRegion
        '
        Me.lblRatingRegion.AutoSize = True
        Me.lblRatingRegion.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRatingRegion.Location = New System.Drawing.Point(8, 21)
        Me.lblRatingRegion.Name = "lblRatingRegion"
        Me.lblRatingRegion.Size = New System.Drawing.Size(99, 13)
        Me.lblRatingRegion.TabIndex = 0
        Me.lblRatingRegion.Text = "TV Rating Region:"
        '
        'cbRatingRegion
        '
        Me.cbRatingRegion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbRatingRegion.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.cbRatingRegion.FormattingEnabled = True
        Me.cbRatingRegion.Location = New System.Drawing.Point(8, 36)
        Me.cbRatingRegion.Name = "cbRatingRegion"
        Me.cbRatingRegion.Size = New System.Drawing.Size(163, 21)
        Me.cbRatingRegion.TabIndex = 1
        '
        'gbShowEpFilter
        '
        Me.gbShowEpFilter.Controls.Add(Me.btnResetEpFilter)
        Me.gbShowEpFilter.Controls.Add(Me.chkNoFilterEpisode)
        Me.gbShowEpFilter.Controls.Add(Me.btnEpFilterDown)
        Me.gbShowEpFilter.Controls.Add(Me.btnEpFilterUp)
        Me.gbShowEpFilter.Controls.Add(Me.chkEpProperCase)
        Me.gbShowEpFilter.Controls.Add(Me.btnRemoveEpFilter)
        Me.gbShowEpFilter.Controls.Add(Me.btnAddEpFilter)
        Me.gbShowEpFilter.Controls.Add(Me.txtEpFilter)
        Me.gbShowEpFilter.Controls.Add(Me.lstEpFilters)
        Me.gbShowEpFilter.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.gbShowEpFilter.Location = New System.Drawing.Point(229, 185)
        Me.gbShowEpFilter.Name = "gbShowEpFilter"
        Me.gbShowEpFilter.Size = New System.Drawing.Size(382, 205)
        Me.gbShowEpFilter.TabIndex = 3
        Me.gbShowEpFilter.TabStop = False
        Me.gbShowEpFilter.Text = "Episode Folder/File Name Filters"
        '
        'btnResetEpFilter
        '
        Me.btnResetEpFilter.Image = CType(resources.GetObject("btnResetEpFilter.Image"), System.Drawing.Image)
        Me.btnResetEpFilter.Location = New System.Drawing.Point(354, 38)
        Me.btnResetEpFilter.Name = "btnResetEpFilter"
        Me.btnResetEpFilter.Size = New System.Drawing.Size(23, 23)
        Me.btnResetEpFilter.TabIndex = 3
        Me.btnResetEpFilter.UseVisualStyleBackColor = True
        '
        'chkNoFilterEpisode
        '
        Me.chkNoFilterEpisode.CheckAlign = System.Drawing.ContentAlignment.TopLeft
        Me.chkNoFilterEpisode.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.chkNoFilterEpisode.Location = New System.Drawing.Point(6, 15)
        Me.chkNoFilterEpisode.Name = "chkNoFilterEpisode"
        Me.chkNoFilterEpisode.Size = New System.Drawing.Size(371, 21)
        Me.chkNoFilterEpisode.TabIndex = 0
        Me.chkNoFilterEpisode.Text = "Build Episode Title Instead of Filtering"
        Me.chkNoFilterEpisode.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.chkNoFilterEpisode.UseVisualStyleBackColor = True
        '
        'btnEpFilterDown
        '
        Me.btnEpFilterDown.Image = CType(resources.GetObject("btnEpFilterDown.Image"), System.Drawing.Image)
        Me.btnEpFilterDown.Location = New System.Drawing.Point(320, 176)
        Me.btnEpFilterDown.Name = "btnEpFilterDown"
        Me.btnEpFilterDown.Size = New System.Drawing.Size(23, 23)
        Me.btnEpFilterDown.TabIndex = 7
        Me.btnEpFilterDown.UseVisualStyleBackColor = True
        '
        'btnEpFilterUp
        '
        Me.btnEpFilterUp.Image = CType(resources.GetObject("btnEpFilterUp.Image"), System.Drawing.Image)
        Me.btnEpFilterUp.Location = New System.Drawing.Point(296, 176)
        Me.btnEpFilterUp.Name = "btnEpFilterUp"
        Me.btnEpFilterUp.Size = New System.Drawing.Size(23, 23)
        Me.btnEpFilterUp.TabIndex = 6
        Me.btnEpFilterUp.UseVisualStyleBackColor = True
        '
        'chkEpProperCase
        '
        Me.chkEpProperCase.AutoSize = True
        Me.chkEpProperCase.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkEpProperCase.Location = New System.Drawing.Point(6, 47)
        Me.chkEpProperCase.Name = "chkEpProperCase"
        Me.chkEpProperCase.Size = New System.Drawing.Size(181, 17)
        Me.chkEpProperCase.TabIndex = 1
        Me.chkEpProperCase.Text = "Convert Names to Proper Case"
        Me.chkEpProperCase.UseVisualStyleBackColor = True
        '
        'btnRemoveEpFilter
        '
        Me.btnRemoveEpFilter.Image = CType(resources.GetObject("btnRemoveEpFilter.Image"), System.Drawing.Image)
        Me.btnRemoveEpFilter.Location = New System.Drawing.Point(354, 176)
        Me.btnRemoveEpFilter.Name = "btnRemoveEpFilter"
        Me.btnRemoveEpFilter.Size = New System.Drawing.Size(23, 23)
        Me.btnRemoveEpFilter.TabIndex = 8
        Me.btnRemoveEpFilter.UseVisualStyleBackColor = True
        '
        'btnAddEpFilter
        '
        Me.btnAddEpFilter.Image = CType(resources.GetObject("btnAddEpFilter.Image"), System.Drawing.Image)
        Me.btnAddEpFilter.Location = New System.Drawing.Point(260, 176)
        Me.btnAddEpFilter.Name = "btnAddEpFilter"
        Me.btnAddEpFilter.Size = New System.Drawing.Size(23, 23)
        Me.btnAddEpFilter.TabIndex = 5
        Me.btnAddEpFilter.UseVisualStyleBackColor = True
        '
        'txtEpFilter
        '
        Me.txtEpFilter.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEpFilter.Location = New System.Drawing.Point(6, 177)
        Me.txtEpFilter.Name = "txtEpFilter"
        Me.txtEpFilter.Size = New System.Drawing.Size(252, 22)
        Me.txtEpFilter.TabIndex = 4
        '
        'lstEpFilters
        '
        Me.lstEpFilters.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lstEpFilters.FormattingEnabled = True
        Me.lstEpFilters.Location = New System.Drawing.Point(6, 64)
        Me.lstEpFilters.Name = "lstEpFilters"
        Me.lstEpFilters.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.lstEpFilters.Size = New System.Drawing.Size(371, 95)
        Me.lstEpFilters.TabIndex = 2
        '
        'gbShowFilter
        '
        Me.gbShowFilter.Controls.Add(Me.btnResetShowFilters)
        Me.gbShowFilter.Controls.Add(Me.btnShowFilterDown)
        Me.gbShowFilter.Controls.Add(Me.btnShowFilterUp)
        Me.gbShowFilter.Controls.Add(Me.chkShowProperCase)
        Me.gbShowFilter.Controls.Add(Me.btnRemoveShowFilter)
        Me.gbShowFilter.Controls.Add(Me.btnAddShowFilter)
        Me.gbShowFilter.Controls.Add(Me.txtShowFilter)
        Me.gbShowFilter.Controls.Add(Me.lstShowFilters)
        Me.gbShowFilter.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.gbShowFilter.Location = New System.Drawing.Point(229, 7)
        Me.gbShowFilter.Name = "gbShowFilter"
        Me.gbShowFilter.Size = New System.Drawing.Size(382, 175)
        Me.gbShowFilter.TabIndex = 2
        Me.gbShowFilter.TabStop = False
        Me.gbShowFilter.Text = "Show Folder/File Name Filters"
        '
        'btnResetShowFilters
        '
        Me.btnResetShowFilters.Image = CType(resources.GetObject("btnResetShowFilters.Image"), System.Drawing.Image)
        Me.btnResetShowFilters.Location = New System.Drawing.Point(354, 9)
        Me.btnResetShowFilters.Name = "btnResetShowFilters"
        Me.btnResetShowFilters.Size = New System.Drawing.Size(23, 23)
        Me.btnResetShowFilters.TabIndex = 2
        Me.btnResetShowFilters.UseVisualStyleBackColor = True
        '
        'btnShowFilterDown
        '
        Me.btnShowFilterDown.Image = CType(resources.GetObject("btnShowFilterDown.Image"), System.Drawing.Image)
        Me.btnShowFilterDown.Location = New System.Drawing.Point(320, 146)
        Me.btnShowFilterDown.Name = "btnShowFilterDown"
        Me.btnShowFilterDown.Size = New System.Drawing.Size(23, 23)
        Me.btnShowFilterDown.TabIndex = 6
        Me.btnShowFilterDown.UseVisualStyleBackColor = True
        '
        'btnShowFilterUp
        '
        Me.btnShowFilterUp.Image = CType(resources.GetObject("btnShowFilterUp.Image"), System.Drawing.Image)
        Me.btnShowFilterUp.Location = New System.Drawing.Point(296, 146)
        Me.btnShowFilterUp.Name = "btnShowFilterUp"
        Me.btnShowFilterUp.Size = New System.Drawing.Size(23, 23)
        Me.btnShowFilterUp.TabIndex = 5
        Me.btnShowFilterUp.UseVisualStyleBackColor = True
        '
        'chkShowProperCase
        '
        Me.chkShowProperCase.AutoSize = True
        Me.chkShowProperCase.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkShowProperCase.Location = New System.Drawing.Point(6, 17)
        Me.chkShowProperCase.Name = "chkShowProperCase"
        Me.chkShowProperCase.Size = New System.Drawing.Size(181, 17)
        Me.chkShowProperCase.TabIndex = 0
        Me.chkShowProperCase.Text = "Convert Names to Proper Case"
        Me.chkShowProperCase.UseVisualStyleBackColor = True
        '
        'btnRemoveShowFilter
        '
        Me.btnRemoveShowFilter.Image = CType(resources.GetObject("btnRemoveShowFilter.Image"), System.Drawing.Image)
        Me.btnRemoveShowFilter.Location = New System.Drawing.Point(354, 146)
        Me.btnRemoveShowFilter.Name = "btnRemoveShowFilter"
        Me.btnRemoveShowFilter.Size = New System.Drawing.Size(23, 23)
        Me.btnRemoveShowFilter.TabIndex = 7
        Me.btnRemoveShowFilter.UseVisualStyleBackColor = True
        '
        'btnAddShowFilter
        '
        Me.btnAddShowFilter.Image = CType(resources.GetObject("btnAddShowFilter.Image"), System.Drawing.Image)
        Me.btnAddShowFilter.Location = New System.Drawing.Point(260, 146)
        Me.btnAddShowFilter.Name = "btnAddShowFilter"
        Me.btnAddShowFilter.Size = New System.Drawing.Size(23, 23)
        Me.btnAddShowFilter.TabIndex = 4
        Me.btnAddShowFilter.UseVisualStyleBackColor = True
        '
        'txtShowFilter
        '
        Me.txtShowFilter.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtShowFilter.Location = New System.Drawing.Point(6, 147)
        Me.txtShowFilter.Name = "txtShowFilter"
        Me.txtShowFilter.Size = New System.Drawing.Size(252, 22)
        Me.txtShowFilter.TabIndex = 3
        '
        'lstShowFilters
        '
        Me.lstShowFilters.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lstShowFilters.FormattingEnabled = True
        Me.lstShowFilters.Location = New System.Drawing.Point(6, 35)
        Me.lstShowFilters.Name = "lstShowFilters"
        Me.lstShowFilters.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.lstShowFilters.Size = New System.Drawing.Size(371, 95)
        Me.lstShowFilters.TabIndex = 1
        '
        'pnlTVImages
        '
        Me.pnlTVImages.BackColor = System.Drawing.Color.White
        Me.pnlTVImages.Controls.Add(Me.TabControl3)
        Me.pnlTVImages.Location = New System.Drawing.Point(900, 900)
        Me.pnlTVImages.Name = "pnlTVImages"
        Me.pnlTVImages.Size = New System.Drawing.Size(635, 435)
        Me.pnlTVImages.TabIndex = 16
        Me.pnlTVImages.Visible = False
        '
        'TabControl3
        '
        Me.TabControl3.Controls.Add(Me.TabPage5)
        Me.TabControl3.Controls.Add(Me.TabPage6)
        Me.TabControl3.Controls.Add(Me.TabPage7)
        Me.TabControl3.Controls.Add(Me.TabPage8)
        Me.TabControl3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.TabControl3.Location = New System.Drawing.Point(5, 6)
        Me.TabControl3.Name = "TabControl3"
        Me.TabControl3.SelectedIndex = 0
        Me.TabControl3.Size = New System.Drawing.Size(609, 397)
        Me.TabControl3.TabIndex = 0
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.gbAllSPosterOpts)
        Me.TabPage5.Controls.Add(Me.gbShowPosterOpts)
        Me.TabPage5.Controls.Add(Me.gbShowFanartOpts)
        Me.TabPage5.Location = New System.Drawing.Point(4, 22)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage5.Size = New System.Drawing.Size(601, 371)
        Me.TabPage5.TabIndex = 0
        Me.TabPage5.Text = "TV Show"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'gbAllSPosterOpts
        '
        Me.gbAllSPosterOpts.Controls.Add(Me.rbAllSPoster)
        Me.gbAllSPosterOpts.Controls.Add(Me.rbAllSBanner)
        Me.gbAllSPosterOpts.Controls.Add(Me.txtAllSPosterWidth)
        Me.gbAllSPosterOpts.Controls.Add(Me.txtAllSPosterHeight)
        Me.gbAllSPosterOpts.Controls.Add(Me.lblAllSPosterQual)
        Me.gbAllSPosterOpts.Controls.Add(Me.tbAllSPosterQual)
        Me.gbAllSPosterOpts.Controls.Add(Me.lblAllSPosterQ)
        Me.gbAllSPosterOpts.Controls.Add(Me.lblAllSPosterWidth)
        Me.gbAllSPosterOpts.Controls.Add(Me.lblAllSPosterHeight)
        Me.gbAllSPosterOpts.Controls.Add(Me.chkResizeAllSPoster)
        Me.gbAllSPosterOpts.Controls.Add(Me.lblAllSPosterSize)
        Me.gbAllSPosterOpts.Controls.Add(Me.cbAllSPosterSize)
        Me.gbAllSPosterOpts.Controls.Add(Me.chkOverwriteAllSPoster)
        Me.gbAllSPosterOpts.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.gbAllSPosterOpts.Location = New System.Drawing.Point(238, 5)
        Me.gbAllSPosterOpts.Name = "gbAllSPosterOpts"
        Me.gbAllSPosterOpts.Size = New System.Drawing.Size(228, 191)
        Me.gbAllSPosterOpts.TabIndex = 0
        Me.gbAllSPosterOpts.TabStop = False
        Me.gbAllSPosterOpts.Text = "All Season Posters"
        '
        'rbAllSPoster
        '
        Me.rbAllSPoster.AutoSize = True
        Me.rbAllSPoster.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.rbAllSPoster.Location = New System.Drawing.Point(93, 30)
        Me.rbAllSPoster.Name = "rbAllSPoster"
        Me.rbAllSPoster.Size = New System.Drawing.Size(57, 17)
        Me.rbAllSPoster.TabIndex = 2
        Me.rbAllSPoster.TabStop = True
        Me.rbAllSPoster.Text = "Poster"
        Me.rbAllSPoster.UseVisualStyleBackColor = True
        '
        'rbAllSBanner
        '
        Me.rbAllSBanner.AutoSize = True
        Me.rbAllSBanner.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.rbAllSBanner.Location = New System.Drawing.Point(8, 30)
        Me.rbAllSBanner.Name = "rbAllSBanner"
        Me.rbAllSBanner.Size = New System.Drawing.Size(62, 17)
        Me.rbAllSBanner.TabIndex = 1
        Me.rbAllSBanner.TabStop = True
        Me.rbAllSBanner.Text = "Banner"
        Me.rbAllSBanner.UseVisualStyleBackColor = True
        '
        'txtAllSPosterWidth
        '
        Me.txtAllSPosterWidth.Enabled = False
        Me.txtAllSPosterWidth.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAllSPosterWidth.Location = New System.Drawing.Point(71, 113)
        Me.txtAllSPosterWidth.Name = "txtAllSPosterWidth"
        Me.txtAllSPosterWidth.Size = New System.Drawing.Size(40, 22)
        Me.txtAllSPosterWidth.TabIndex = 7
        '
        'txtAllSPosterHeight
        '
        Me.txtAllSPosterHeight.Enabled = False
        Me.txtAllSPosterHeight.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAllSPosterHeight.Location = New System.Drawing.Point(182, 113)
        Me.txtAllSPosterHeight.Name = "txtAllSPosterHeight"
        Me.txtAllSPosterHeight.Size = New System.Drawing.Size(40, 22)
        Me.txtAllSPosterHeight.TabIndex = 9
        '
        'lblAllSPosterQual
        '
        Me.lblAllSPosterQual.AutoSize = True
        Me.lblAllSPosterQual.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lblAllSPosterQual.Location = New System.Drawing.Point(183, 161)
        Me.lblAllSPosterQual.Name = "lblAllSPosterQual"
        Me.lblAllSPosterQual.Size = New System.Drawing.Size(29, 17)
        Me.lblAllSPosterQual.TabIndex = 12
        Me.lblAllSPosterQual.Text = "100"
        '
        'tbAllSPosterQual
        '
        Me.tbAllSPosterQual.AutoSize = False
        Me.tbAllSPosterQual.BackColor = System.Drawing.Color.White
        Me.tbAllSPosterQual.LargeChange = 10
        Me.tbAllSPosterQual.Location = New System.Drawing.Point(7, 154)
        Me.tbAllSPosterQual.Maximum = 100
        Me.tbAllSPosterQual.Name = "tbAllSPosterQual"
        Me.tbAllSPosterQual.Size = New System.Drawing.Size(179, 27)
        Me.tbAllSPosterQual.TabIndex = 11
        Me.tbAllSPosterQual.TickFrequency = 10
        Me.tbAllSPosterQual.Value = 100
        '
        'lblAllSPosterQ
        '
        Me.lblAllSPosterQ.AutoSize = True
        Me.lblAllSPosterQ.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAllSPosterQ.Location = New System.Drawing.Point(3, 141)
        Me.lblAllSPosterQ.Name = "lblAllSPosterQ"
        Me.lblAllSPosterQ.Size = New System.Drawing.Size(46, 13)
        Me.lblAllSPosterQ.TabIndex = 10
        Me.lblAllSPosterQ.Text = "Quality:"
        '
        'lblAllSPosterWidth
        '
        Me.lblAllSPosterWidth.AutoSize = True
        Me.lblAllSPosterWidth.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAllSPosterWidth.Location = New System.Drawing.Point(3, 117)
        Me.lblAllSPosterWidth.Name = "lblAllSPosterWidth"
        Me.lblAllSPosterWidth.Size = New System.Drawing.Size(66, 13)
        Me.lblAllSPosterWidth.TabIndex = 6
        Me.lblAllSPosterWidth.Text = "Max Width:"
        '
        'lblAllSPosterHeight
        '
        Me.lblAllSPosterHeight.AutoSize = True
        Me.lblAllSPosterHeight.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAllSPosterHeight.Location = New System.Drawing.Point(112, 117)
        Me.lblAllSPosterHeight.Name = "lblAllSPosterHeight"
        Me.lblAllSPosterHeight.Size = New System.Drawing.Size(69, 13)
        Me.lblAllSPosterHeight.TabIndex = 8
        Me.lblAllSPosterHeight.Text = "Max Height:"
        '
        'chkResizeAllSPoster
        '
        Me.chkResizeAllSPoster.AutoSize = True
        Me.chkResizeAllSPoster.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkResizeAllSPoster.Location = New System.Drawing.Point(6, 92)
        Me.chkResizeAllSPoster.Name = "chkResizeAllSPoster"
        Me.chkResizeAllSPoster.Size = New System.Drawing.Size(133, 17)
        Me.chkResizeAllSPoster.TabIndex = 5
        Me.chkResizeAllSPoster.Text = "Automatically Resize:"
        Me.chkResizeAllSPoster.UseVisualStyleBackColor = True
        '
        'lblAllSPosterSize
        '
        Me.lblAllSPosterSize.AutoSize = True
        Me.lblAllSPosterSize.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAllSPosterSize.Location = New System.Drawing.Point(3, 14)
        Me.lblAllSPosterSize.Name = "lblAllSPosterSize"
        Me.lblAllSPosterSize.Size = New System.Drawing.Size(83, 13)
        Me.lblAllSPosterSize.TabIndex = 0
        Me.lblAllSPosterSize.Text = "Preferred Type:"
        '
        'cbAllSPosterSize
        '
        Me.cbAllSPosterSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbAllSPosterSize.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.cbAllSPosterSize.FormattingEnabled = True
        Me.cbAllSPosterSize.Location = New System.Drawing.Point(6, 52)
        Me.cbAllSPosterSize.Name = "cbAllSPosterSize"
        Me.cbAllSPosterSize.Size = New System.Drawing.Size(148, 21)
        Me.cbAllSPosterSize.TabIndex = 3
        '
        'chkOverwriteAllSPoster
        '
        Me.chkOverwriteAllSPoster.AutoSize = True
        Me.chkOverwriteAllSPoster.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkOverwriteAllSPoster.Location = New System.Drawing.Point(6, 76)
        Me.chkOverwriteAllSPoster.Name = "chkOverwriteAllSPoster"
        Me.chkOverwriteAllSPoster.Size = New System.Drawing.Size(119, 17)
        Me.chkOverwriteAllSPoster.TabIndex = 4
        Me.chkOverwriteAllSPoster.Text = "Overwrite Existing"
        Me.chkOverwriteAllSPoster.UseVisualStyleBackColor = True
        '
        'gbShowPosterOpts
        '
        Me.gbShowPosterOpts.Controls.Add(Me.rbPoster)
        Me.gbShowPosterOpts.Controls.Add(Me.rbBanner)
        Me.gbShowPosterOpts.Controls.Add(Me.txtShowPosterWidth)
        Me.gbShowPosterOpts.Controls.Add(Me.txtShowPosterHeight)
        Me.gbShowPosterOpts.Controls.Add(Me.lblShowPosterQual)
        Me.gbShowPosterOpts.Controls.Add(Me.tbShowPosterQual)
        Me.gbShowPosterOpts.Controls.Add(Me.lblShowPosterQ)
        Me.gbShowPosterOpts.Controls.Add(Me.lblShowPosterWidth)
        Me.gbShowPosterOpts.Controls.Add(Me.lblShowPosterHeight)
        Me.gbShowPosterOpts.Controls.Add(Me.chkResizeShowPoster)
        Me.gbShowPosterOpts.Controls.Add(Me.lblShowPosterSize)
        Me.gbShowPosterOpts.Controls.Add(Me.cbShowPosterSize)
        Me.gbShowPosterOpts.Controls.Add(Me.chkOverwriteShowPoster)
        Me.gbShowPosterOpts.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.gbShowPosterOpts.Location = New System.Drawing.Point(4, 5)
        Me.gbShowPosterOpts.Name = "gbShowPosterOpts"
        Me.gbShowPosterOpts.Size = New System.Drawing.Size(228, 191)
        Me.gbShowPosterOpts.TabIndex = 0
        Me.gbShowPosterOpts.TabStop = False
        Me.gbShowPosterOpts.Text = "Poster"
        '
        'rbPoster
        '
        Me.rbPoster.AutoSize = True
        Me.rbPoster.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.rbPoster.Location = New System.Drawing.Point(93, 30)
        Me.rbPoster.Name = "rbPoster"
        Me.rbPoster.Size = New System.Drawing.Size(57, 17)
        Me.rbPoster.TabIndex = 2
        Me.rbPoster.TabStop = True
        Me.rbPoster.Text = "Poster"
        Me.rbPoster.UseVisualStyleBackColor = True
        '
        'rbBanner
        '
        Me.rbBanner.AutoSize = True
        Me.rbBanner.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.rbBanner.Location = New System.Drawing.Point(8, 30)
        Me.rbBanner.Name = "rbBanner"
        Me.rbBanner.Size = New System.Drawing.Size(62, 17)
        Me.rbBanner.TabIndex = 1
        Me.rbBanner.TabStop = True
        Me.rbBanner.Text = "Banner"
        Me.rbBanner.UseVisualStyleBackColor = True
        '
        'txtShowPosterWidth
        '
        Me.txtShowPosterWidth.Enabled = False
        Me.txtShowPosterWidth.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtShowPosterWidth.Location = New System.Drawing.Point(71, 113)
        Me.txtShowPosterWidth.Name = "txtShowPosterWidth"
        Me.txtShowPosterWidth.Size = New System.Drawing.Size(40, 22)
        Me.txtShowPosterWidth.TabIndex = 7
        '
        'txtShowPosterHeight
        '
        Me.txtShowPosterHeight.Enabled = False
        Me.txtShowPosterHeight.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtShowPosterHeight.Location = New System.Drawing.Point(182, 113)
        Me.txtShowPosterHeight.Name = "txtShowPosterHeight"
        Me.txtShowPosterHeight.Size = New System.Drawing.Size(40, 22)
        Me.txtShowPosterHeight.TabIndex = 9
        '
        'lblShowPosterQual
        '
        Me.lblShowPosterQual.AutoSize = True
        Me.lblShowPosterQual.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lblShowPosterQual.Location = New System.Drawing.Point(183, 161)
        Me.lblShowPosterQual.Name = "lblShowPosterQual"
        Me.lblShowPosterQual.Size = New System.Drawing.Size(29, 17)
        Me.lblShowPosterQual.TabIndex = 12
        Me.lblShowPosterQual.Text = "100"
        '
        'tbShowPosterQual
        '
        Me.tbShowPosterQual.AutoSize = False
        Me.tbShowPosterQual.BackColor = System.Drawing.Color.White
        Me.tbShowPosterQual.LargeChange = 10
        Me.tbShowPosterQual.Location = New System.Drawing.Point(7, 154)
        Me.tbShowPosterQual.Maximum = 100
        Me.tbShowPosterQual.Name = "tbShowPosterQual"
        Me.tbShowPosterQual.Size = New System.Drawing.Size(179, 27)
        Me.tbShowPosterQual.TabIndex = 11
        Me.tbShowPosterQual.TickFrequency = 10
        Me.tbShowPosterQual.Value = 100
        '
        'lblShowPosterQ
        '
        Me.lblShowPosterQ.AutoSize = True
        Me.lblShowPosterQ.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblShowPosterQ.Location = New System.Drawing.Point(3, 141)
        Me.lblShowPosterQ.Name = "lblShowPosterQ"
        Me.lblShowPosterQ.Size = New System.Drawing.Size(46, 13)
        Me.lblShowPosterQ.TabIndex = 10
        Me.lblShowPosterQ.Text = "Quality:"
        '
        'lblShowPosterWidth
        '
        Me.lblShowPosterWidth.AutoSize = True
        Me.lblShowPosterWidth.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblShowPosterWidth.Location = New System.Drawing.Point(3, 117)
        Me.lblShowPosterWidth.Name = "lblShowPosterWidth"
        Me.lblShowPosterWidth.Size = New System.Drawing.Size(66, 13)
        Me.lblShowPosterWidth.TabIndex = 6
        Me.lblShowPosterWidth.Text = "Max Width:"
        '
        'lblShowPosterHeight
        '
        Me.lblShowPosterHeight.AutoSize = True
        Me.lblShowPosterHeight.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblShowPosterHeight.Location = New System.Drawing.Point(112, 117)
        Me.lblShowPosterHeight.Name = "lblShowPosterHeight"
        Me.lblShowPosterHeight.Size = New System.Drawing.Size(69, 13)
        Me.lblShowPosterHeight.TabIndex = 8
        Me.lblShowPosterHeight.Text = "Max Height:"
        '
        'chkResizeShowPoster
        '
        Me.chkResizeShowPoster.AutoSize = True
        Me.chkResizeShowPoster.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkResizeShowPoster.Location = New System.Drawing.Point(6, 92)
        Me.chkResizeShowPoster.Name = "chkResizeShowPoster"
        Me.chkResizeShowPoster.Size = New System.Drawing.Size(133, 17)
        Me.chkResizeShowPoster.TabIndex = 5
        Me.chkResizeShowPoster.Text = "Automatically Resize:"
        Me.chkResizeShowPoster.UseVisualStyleBackColor = True
        '
        'lblShowPosterSize
        '
        Me.lblShowPosterSize.AutoSize = True
        Me.lblShowPosterSize.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblShowPosterSize.Location = New System.Drawing.Point(3, 14)
        Me.lblShowPosterSize.Name = "lblShowPosterSize"
        Me.lblShowPosterSize.Size = New System.Drawing.Size(83, 13)
        Me.lblShowPosterSize.TabIndex = 0
        Me.lblShowPosterSize.Text = "Preferred Type:"
        '
        'cbShowPosterSize
        '
        Me.cbShowPosterSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbShowPosterSize.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.cbShowPosterSize.FormattingEnabled = True
        Me.cbShowPosterSize.Location = New System.Drawing.Point(6, 52)
        Me.cbShowPosterSize.Name = "cbShowPosterSize"
        Me.cbShowPosterSize.Size = New System.Drawing.Size(148, 21)
        Me.cbShowPosterSize.TabIndex = 3
        '
        'chkOverwriteShowPoster
        '
        Me.chkOverwriteShowPoster.AutoSize = True
        Me.chkOverwriteShowPoster.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkOverwriteShowPoster.Location = New System.Drawing.Point(6, 76)
        Me.chkOverwriteShowPoster.Name = "chkOverwriteShowPoster"
        Me.chkOverwriteShowPoster.Size = New System.Drawing.Size(119, 17)
        Me.chkOverwriteShowPoster.TabIndex = 4
        Me.chkOverwriteShowPoster.Text = "Overwrite Existing"
        Me.chkOverwriteShowPoster.UseVisualStyleBackColor = True
        '
        'gbShowFanartOpts
        '
        Me.gbShowFanartOpts.Controls.Add(Me.txtShowFanartWidth)
        Me.gbShowFanartOpts.Controls.Add(Me.txtShowFanartHeight)
        Me.gbShowFanartOpts.Controls.Add(Me.lblShowFanartQual)
        Me.gbShowFanartOpts.Controls.Add(Me.tbShowFanartQual)
        Me.gbShowFanartOpts.Controls.Add(Me.lblShowFanartQ)
        Me.gbShowFanartOpts.Controls.Add(Me.lblShowFanartWidth)
        Me.gbShowFanartOpts.Controls.Add(Me.lblShowFanartHeight)
        Me.gbShowFanartOpts.Controls.Add(Me.chkResizeShowFanart)
        Me.gbShowFanartOpts.Controls.Add(Me.cbShowFanartSize)
        Me.gbShowFanartOpts.Controls.Add(Me.lblShowFanartSize)
        Me.gbShowFanartOpts.Controls.Add(Me.chkOverwriteShowFanart)
        Me.gbShowFanartOpts.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.gbShowFanartOpts.Location = New System.Drawing.Point(4, 199)
        Me.gbShowFanartOpts.Name = "gbShowFanartOpts"
        Me.gbShowFanartOpts.Size = New System.Drawing.Size(228, 167)
        Me.gbShowFanartOpts.TabIndex = 1
        Me.gbShowFanartOpts.TabStop = False
        Me.gbShowFanartOpts.Text = "Fanart"
        '
        'txtShowFanartWidth
        '
        Me.txtShowFanartWidth.Enabled = False
        Me.txtShowFanartWidth.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtShowFanartWidth.Location = New System.Drawing.Point(71, 90)
        Me.txtShowFanartWidth.Name = "txtShowFanartWidth"
        Me.txtShowFanartWidth.Size = New System.Drawing.Size(40, 22)
        Me.txtShowFanartWidth.TabIndex = 5
        '
        'txtShowFanartHeight
        '
        Me.txtShowFanartHeight.Enabled = False
        Me.txtShowFanartHeight.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtShowFanartHeight.Location = New System.Drawing.Point(182, 90)
        Me.txtShowFanartHeight.Name = "txtShowFanartHeight"
        Me.txtShowFanartHeight.Size = New System.Drawing.Size(40, 22)
        Me.txtShowFanartHeight.TabIndex = 7
        '
        'lblShowFanartQual
        '
        Me.lblShowFanartQual.AutoSize = True
        Me.lblShowFanartQual.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lblShowFanartQual.Location = New System.Drawing.Point(183, 138)
        Me.lblShowFanartQual.Name = "lblShowFanartQual"
        Me.lblShowFanartQual.Size = New System.Drawing.Size(29, 17)
        Me.lblShowFanartQual.TabIndex = 10
        Me.lblShowFanartQual.Text = "100"
        '
        'tbShowFanartQual
        '
        Me.tbShowFanartQual.AutoSize = False
        Me.tbShowFanartQual.BackColor = System.Drawing.Color.White
        Me.tbShowFanartQual.LargeChange = 10
        Me.tbShowFanartQual.Location = New System.Drawing.Point(7, 131)
        Me.tbShowFanartQual.Maximum = 100
        Me.tbShowFanartQual.Name = "tbShowFanartQual"
        Me.tbShowFanartQual.Size = New System.Drawing.Size(180, 27)
        Me.tbShowFanartQual.TabIndex = 9
        Me.tbShowFanartQual.TickFrequency = 10
        Me.tbShowFanartQual.Value = 100
        '
        'lblShowFanartQ
        '
        Me.lblShowFanartQ.AutoSize = True
        Me.lblShowFanartQ.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblShowFanartQ.Location = New System.Drawing.Point(3, 118)
        Me.lblShowFanartQ.Name = "lblShowFanartQ"
        Me.lblShowFanartQ.Size = New System.Drawing.Size(46, 13)
        Me.lblShowFanartQ.TabIndex = 8
        Me.lblShowFanartQ.Text = "Quality:"
        '
        'lblShowFanartWidth
        '
        Me.lblShowFanartWidth.AutoSize = True
        Me.lblShowFanartWidth.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblShowFanartWidth.Location = New System.Drawing.Point(3, 94)
        Me.lblShowFanartWidth.Name = "lblShowFanartWidth"
        Me.lblShowFanartWidth.Size = New System.Drawing.Size(66, 13)
        Me.lblShowFanartWidth.TabIndex = 4
        Me.lblShowFanartWidth.Text = "Max Width:"
        '
        'lblShowFanartHeight
        '
        Me.lblShowFanartHeight.AutoSize = True
        Me.lblShowFanartHeight.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblShowFanartHeight.Location = New System.Drawing.Point(112, 94)
        Me.lblShowFanartHeight.Name = "lblShowFanartHeight"
        Me.lblShowFanartHeight.Size = New System.Drawing.Size(69, 13)
        Me.lblShowFanartHeight.TabIndex = 6
        Me.lblShowFanartHeight.Text = "Max Height:"
        '
        'chkResizeShowFanart
        '
        Me.chkResizeShowFanart.AutoSize = True
        Me.chkResizeShowFanart.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkResizeShowFanart.Location = New System.Drawing.Point(6, 69)
        Me.chkResizeShowFanart.Name = "chkResizeShowFanart"
        Me.chkResizeShowFanart.Size = New System.Drawing.Size(133, 17)
        Me.chkResizeShowFanart.TabIndex = 3
        Me.chkResizeShowFanart.Text = "Automatically Resize:"
        Me.chkResizeShowFanart.UseVisualStyleBackColor = True
        '
        'cbShowFanartSize
        '
        Me.cbShowFanartSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbShowFanartSize.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.cbShowFanartSize.FormattingEnabled = True
        Me.cbShowFanartSize.Location = New System.Drawing.Point(6, 29)
        Me.cbShowFanartSize.Name = "cbShowFanartSize"
        Me.cbShowFanartSize.Size = New System.Drawing.Size(148, 21)
        Me.cbShowFanartSize.TabIndex = 1
        '
        'lblShowFanartSize
        '
        Me.lblShowFanartSize.AutoSize = True
        Me.lblShowFanartSize.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblShowFanartSize.Location = New System.Drawing.Point(3, 14)
        Me.lblShowFanartSize.Name = "lblShowFanartSize"
        Me.lblShowFanartSize.Size = New System.Drawing.Size(80, 13)
        Me.lblShowFanartSize.TabIndex = 0
        Me.lblShowFanartSize.Text = "Preferred Size:"
        '
        'chkOverwriteShowFanart
        '
        Me.chkOverwriteShowFanart.AutoSize = True
        Me.chkOverwriteShowFanart.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkOverwriteShowFanart.Location = New System.Drawing.Point(6, 53)
        Me.chkOverwriteShowFanart.Name = "chkOverwriteShowFanart"
        Me.chkOverwriteShowFanart.Size = New System.Drawing.Size(119, 17)
        Me.chkOverwriteShowFanart.TabIndex = 2
        Me.chkOverwriteShowFanart.Text = "Overwrite Existing"
        Me.chkOverwriteShowFanart.UseVisualStyleBackColor = True
        '
        'TabPage6
        '
        Me.TabPage6.Controls.Add(Me.gbSeaPosterOpts)
        Me.TabPage6.Controls.Add(Me.gbSeaFanartOpts)
        Me.TabPage6.Location = New System.Drawing.Point(4, 22)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Size = New System.Drawing.Size(601, 371)
        Me.TabPage6.TabIndex = 2
        Me.TabPage6.Text = "TV Season"
        Me.TabPage6.UseVisualStyleBackColor = True
        '
        'gbSeaPosterOpts
        '
        Me.gbSeaPosterOpts.Controls.Add(Me.txtSeaPosterWidth)
        Me.gbSeaPosterOpts.Controls.Add(Me.txtSeaPosterHeight)
        Me.gbSeaPosterOpts.Controls.Add(Me.lblSeaPosterQual)
        Me.gbSeaPosterOpts.Controls.Add(Me.tbSeaPosterQual)
        Me.gbSeaPosterOpts.Controls.Add(Me.lblSeaPosterQ)
        Me.gbSeaPosterOpts.Controls.Add(Me.lblSeaPosterWidth)
        Me.gbSeaPosterOpts.Controls.Add(Me.lblSeaPosterHeight)
        Me.gbSeaPosterOpts.Controls.Add(Me.chkSeaResizePoster)
        Me.gbSeaPosterOpts.Controls.Add(Me.lblSeaPosterSize)
        Me.gbSeaPosterOpts.Controls.Add(Me.cbSeaPosterSize)
        Me.gbSeaPosterOpts.Controls.Add(Me.chkSeaOverwritePoster)
        Me.gbSeaPosterOpts.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.gbSeaPosterOpts.Location = New System.Drawing.Point(4, 5)
        Me.gbSeaPosterOpts.Name = "gbSeaPosterOpts"
        Me.gbSeaPosterOpts.Size = New System.Drawing.Size(228, 167)
        Me.gbSeaPosterOpts.TabIndex = 0
        Me.gbSeaPosterOpts.TabStop = False
        Me.gbSeaPosterOpts.Text = "Poster"
        '
        'txtSeaPosterWidth
        '
        Me.txtSeaPosterWidth.Enabled = False
        Me.txtSeaPosterWidth.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSeaPosterWidth.Location = New System.Drawing.Point(71, 90)
        Me.txtSeaPosterWidth.Name = "txtSeaPosterWidth"
        Me.txtSeaPosterWidth.Size = New System.Drawing.Size(40, 22)
        Me.txtSeaPosterWidth.TabIndex = 5
        '
        'txtSeaPosterHeight
        '
        Me.txtSeaPosterHeight.Enabled = False
        Me.txtSeaPosterHeight.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSeaPosterHeight.Location = New System.Drawing.Point(182, 90)
        Me.txtSeaPosterHeight.Name = "txtSeaPosterHeight"
        Me.txtSeaPosterHeight.Size = New System.Drawing.Size(40, 22)
        Me.txtSeaPosterHeight.TabIndex = 7
        '
        'lblSeaPosterQual
        '
        Me.lblSeaPosterQual.AutoSize = True
        Me.lblSeaPosterQual.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSeaPosterQual.Location = New System.Drawing.Point(183, 138)
        Me.lblSeaPosterQual.Name = "lblSeaPosterQual"
        Me.lblSeaPosterQual.Size = New System.Drawing.Size(29, 17)
        Me.lblSeaPosterQual.TabIndex = 10
        Me.lblSeaPosterQual.Text = "100"
        '
        'tbSeaPosterQual
        '
        Me.tbSeaPosterQual.AutoSize = False
        Me.tbSeaPosterQual.BackColor = System.Drawing.Color.White
        Me.tbSeaPosterQual.LargeChange = 10
        Me.tbSeaPosterQual.Location = New System.Drawing.Point(7, 131)
        Me.tbSeaPosterQual.Maximum = 100
        Me.tbSeaPosterQual.Name = "tbSeaPosterQual"
        Me.tbSeaPosterQual.Size = New System.Drawing.Size(179, 27)
        Me.tbSeaPosterQual.TabIndex = 9
        Me.tbSeaPosterQual.TickFrequency = 10
        Me.tbSeaPosterQual.Value = 100
        '
        'lblSeaPosterQ
        '
        Me.lblSeaPosterQ.AutoSize = True
        Me.lblSeaPosterQ.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSeaPosterQ.Location = New System.Drawing.Point(3, 118)
        Me.lblSeaPosterQ.Name = "lblSeaPosterQ"
        Me.lblSeaPosterQ.Size = New System.Drawing.Size(46, 13)
        Me.lblSeaPosterQ.TabIndex = 8
        Me.lblSeaPosterQ.Text = "Quality:"
        '
        'lblSeaPosterWidth
        '
        Me.lblSeaPosterWidth.AutoSize = True
        Me.lblSeaPosterWidth.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSeaPosterWidth.Location = New System.Drawing.Point(3, 94)
        Me.lblSeaPosterWidth.Name = "lblSeaPosterWidth"
        Me.lblSeaPosterWidth.Size = New System.Drawing.Size(66, 13)
        Me.lblSeaPosterWidth.TabIndex = 4
        Me.lblSeaPosterWidth.Text = "Max Width:"
        '
        'lblSeaPosterHeight
        '
        Me.lblSeaPosterHeight.AutoSize = True
        Me.lblSeaPosterHeight.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSeaPosterHeight.Location = New System.Drawing.Point(112, 94)
        Me.lblSeaPosterHeight.Name = "lblSeaPosterHeight"
        Me.lblSeaPosterHeight.Size = New System.Drawing.Size(69, 13)
        Me.lblSeaPosterHeight.TabIndex = 6
        Me.lblSeaPosterHeight.Text = "Max Height:"
        '
        'chkSeaResizePoster
        '
        Me.chkSeaResizePoster.AutoSize = True
        Me.chkSeaResizePoster.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSeaResizePoster.Location = New System.Drawing.Point(6, 69)
        Me.chkSeaResizePoster.Name = "chkSeaResizePoster"
        Me.chkSeaResizePoster.Size = New System.Drawing.Size(133, 17)
        Me.chkSeaResizePoster.TabIndex = 3
        Me.chkSeaResizePoster.Text = "Automatically Resize:"
        Me.chkSeaResizePoster.UseVisualStyleBackColor = True
        '
        'lblSeaPosterSize
        '
        Me.lblSeaPosterSize.AutoSize = True
        Me.lblSeaPosterSize.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSeaPosterSize.Location = New System.Drawing.Point(3, 14)
        Me.lblSeaPosterSize.Name = "lblSeaPosterSize"
        Me.lblSeaPosterSize.Size = New System.Drawing.Size(83, 13)
        Me.lblSeaPosterSize.TabIndex = 0
        Me.lblSeaPosterSize.Text = "Preferred Type:"
        '
        'cbSeaPosterSize
        '
        Me.cbSeaPosterSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbSeaPosterSize.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.cbSeaPosterSize.FormattingEnabled = True
        Me.cbSeaPosterSize.Location = New System.Drawing.Point(6, 29)
        Me.cbSeaPosterSize.Name = "cbSeaPosterSize"
        Me.cbSeaPosterSize.Size = New System.Drawing.Size(148, 21)
        Me.cbSeaPosterSize.TabIndex = 1
        '
        'chkSeaOverwritePoster
        '
        Me.chkSeaOverwritePoster.AutoSize = True
        Me.chkSeaOverwritePoster.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSeaOverwritePoster.Location = New System.Drawing.Point(6, 53)
        Me.chkSeaOverwritePoster.Name = "chkSeaOverwritePoster"
        Me.chkSeaOverwritePoster.Size = New System.Drawing.Size(119, 17)
        Me.chkSeaOverwritePoster.TabIndex = 2
        Me.chkSeaOverwritePoster.Text = "Overwrite Existing"
        Me.chkSeaOverwritePoster.UseVisualStyleBackColor = True
        '
        'gbSeaFanartOpts
        '
        Me.gbSeaFanartOpts.Controls.Add(Me.txtSeaFanartWidth)
        Me.gbSeaFanartOpts.Controls.Add(Me.txtSeaFanartHeight)
        Me.gbSeaFanartOpts.Controls.Add(Me.lblSeaFanartQual)
        Me.gbSeaFanartOpts.Controls.Add(Me.tbSeaFanartQual)
        Me.gbSeaFanartOpts.Controls.Add(Me.lblSeaFanartQ)
        Me.gbSeaFanartOpts.Controls.Add(Me.lblSeaFanartWidth)
        Me.gbSeaFanartOpts.Controls.Add(Me.lblSeaFanartHeight)
        Me.gbSeaFanartOpts.Controls.Add(Me.chkSeaResizeFanart)
        Me.gbSeaFanartOpts.Controls.Add(Me.cbSeaFanartSize)
        Me.gbSeaFanartOpts.Controls.Add(Me.lblSeaFanartSize)
        Me.gbSeaFanartOpts.Controls.Add(Me.chkSeaOverwriteFanart)
        Me.gbSeaFanartOpts.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.gbSeaFanartOpts.Location = New System.Drawing.Point(238, 5)
        Me.gbSeaFanartOpts.Name = "gbSeaFanartOpts"
        Me.gbSeaFanartOpts.Size = New System.Drawing.Size(228, 167)
        Me.gbSeaFanartOpts.TabIndex = 1
        Me.gbSeaFanartOpts.TabStop = False
        Me.gbSeaFanartOpts.Text = "Fanart"
        '
        'txtSeaFanartWidth
        '
        Me.txtSeaFanartWidth.Enabled = False
        Me.txtSeaFanartWidth.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSeaFanartWidth.Location = New System.Drawing.Point(71, 90)
        Me.txtSeaFanartWidth.Name = "txtSeaFanartWidth"
        Me.txtSeaFanartWidth.Size = New System.Drawing.Size(40, 22)
        Me.txtSeaFanartWidth.TabIndex = 5
        '
        'txtSeaFanartHeight
        '
        Me.txtSeaFanartHeight.Enabled = False
        Me.txtSeaFanartHeight.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSeaFanartHeight.Location = New System.Drawing.Point(182, 90)
        Me.txtSeaFanartHeight.Name = "txtSeaFanartHeight"
        Me.txtSeaFanartHeight.Size = New System.Drawing.Size(40, 22)
        Me.txtSeaFanartHeight.TabIndex = 7
        '
        'lblSeaFanartQual
        '
        Me.lblSeaFanartQual.AutoSize = True
        Me.lblSeaFanartQual.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSeaFanartQual.Location = New System.Drawing.Point(183, 138)
        Me.lblSeaFanartQual.Name = "lblSeaFanartQual"
        Me.lblSeaFanartQual.Size = New System.Drawing.Size(29, 17)
        Me.lblSeaFanartQual.TabIndex = 10
        Me.lblSeaFanartQual.Text = "100"
        '
        'tbSeaFanartQual
        '
        Me.tbSeaFanartQual.AutoSize = False
        Me.tbSeaFanartQual.BackColor = System.Drawing.Color.White
        Me.tbSeaFanartQual.LargeChange = 10
        Me.tbSeaFanartQual.Location = New System.Drawing.Point(7, 131)
        Me.tbSeaFanartQual.Maximum = 100
        Me.tbSeaFanartQual.Name = "tbSeaFanartQual"
        Me.tbSeaFanartQual.Size = New System.Drawing.Size(180, 27)
        Me.tbSeaFanartQual.TabIndex = 9
        Me.tbSeaFanartQual.TickFrequency = 10
        Me.tbSeaFanartQual.Value = 100
        '
        'lblSeaFanartQ
        '
        Me.lblSeaFanartQ.AutoSize = True
        Me.lblSeaFanartQ.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSeaFanartQ.Location = New System.Drawing.Point(3, 118)
        Me.lblSeaFanartQ.Name = "lblSeaFanartQ"
        Me.lblSeaFanartQ.Size = New System.Drawing.Size(46, 13)
        Me.lblSeaFanartQ.TabIndex = 8
        Me.lblSeaFanartQ.Text = "Quality:"
        '
        'lblSeaFanartWidth
        '
        Me.lblSeaFanartWidth.AutoSize = True
        Me.lblSeaFanartWidth.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSeaFanartWidth.Location = New System.Drawing.Point(3, 94)
        Me.lblSeaFanartWidth.Name = "lblSeaFanartWidth"
        Me.lblSeaFanartWidth.Size = New System.Drawing.Size(66, 13)
        Me.lblSeaFanartWidth.TabIndex = 4
        Me.lblSeaFanartWidth.Text = "Max Width:"
        '
        'lblSeaFanartHeight
        '
        Me.lblSeaFanartHeight.AutoSize = True
        Me.lblSeaFanartHeight.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSeaFanartHeight.Location = New System.Drawing.Point(112, 94)
        Me.lblSeaFanartHeight.Name = "lblSeaFanartHeight"
        Me.lblSeaFanartHeight.Size = New System.Drawing.Size(69, 13)
        Me.lblSeaFanartHeight.TabIndex = 6
        Me.lblSeaFanartHeight.Text = "Max Height:"
        '
        'chkSeaResizeFanart
        '
        Me.chkSeaResizeFanart.AutoSize = True
        Me.chkSeaResizeFanart.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSeaResizeFanart.Location = New System.Drawing.Point(6, 69)
        Me.chkSeaResizeFanart.Name = "chkSeaResizeFanart"
        Me.chkSeaResizeFanart.Size = New System.Drawing.Size(133, 17)
        Me.chkSeaResizeFanart.TabIndex = 3
        Me.chkSeaResizeFanart.Text = "Automatically Resize:"
        Me.chkSeaResizeFanart.UseVisualStyleBackColor = True
        '
        'cbSeaFanartSize
        '
        Me.cbSeaFanartSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbSeaFanartSize.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.cbSeaFanartSize.FormattingEnabled = True
        Me.cbSeaFanartSize.Location = New System.Drawing.Point(6, 29)
        Me.cbSeaFanartSize.Name = "cbSeaFanartSize"
        Me.cbSeaFanartSize.Size = New System.Drawing.Size(148, 21)
        Me.cbSeaFanartSize.TabIndex = 1
        '
        'lblSeaFanartSize
        '
        Me.lblSeaFanartSize.AutoSize = True
        Me.lblSeaFanartSize.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSeaFanartSize.Location = New System.Drawing.Point(3, 14)
        Me.lblSeaFanartSize.Name = "lblSeaFanartSize"
        Me.lblSeaFanartSize.Size = New System.Drawing.Size(80, 13)
        Me.lblSeaFanartSize.TabIndex = 0
        Me.lblSeaFanartSize.Text = "Preferred Size:"
        '
        'chkSeaOverwriteFanart
        '
        Me.chkSeaOverwriteFanart.AutoSize = True
        Me.chkSeaOverwriteFanart.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSeaOverwriteFanart.Location = New System.Drawing.Point(6, 53)
        Me.chkSeaOverwriteFanart.Name = "chkSeaOverwriteFanart"
        Me.chkSeaOverwriteFanart.Size = New System.Drawing.Size(119, 17)
        Me.chkSeaOverwriteFanart.TabIndex = 2
        Me.chkSeaOverwriteFanart.Text = "Overwrite Existing"
        Me.chkSeaOverwriteFanart.UseVisualStyleBackColor = True
        '
        'TabPage7
        '
        Me.TabPage7.Controls.Add(Me.gbEpPosterOpts)
        Me.TabPage7.Controls.Add(Me.gbEpFanartOpts)
        Me.TabPage7.Location = New System.Drawing.Point(4, 22)
        Me.TabPage7.Name = "TabPage7"
        Me.TabPage7.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage7.Size = New System.Drawing.Size(601, 371)
        Me.TabPage7.TabIndex = 1
        Me.TabPage7.Text = "TV Episode"
        Me.TabPage7.UseVisualStyleBackColor = True
        '
        'gbEpPosterOpts
        '
        Me.gbEpPosterOpts.Controls.Add(Me.txtEpPosterWidth)
        Me.gbEpPosterOpts.Controls.Add(Me.txtEpPosterHeight)
        Me.gbEpPosterOpts.Controls.Add(Me.lblEpPosterQual)
        Me.gbEpPosterOpts.Controls.Add(Me.tbEpPosterQual)
        Me.gbEpPosterOpts.Controls.Add(Me.lblEpPosterQ)
        Me.gbEpPosterOpts.Controls.Add(Me.lblEpPosterWidth)
        Me.gbEpPosterOpts.Controls.Add(Me.lblEpPosterHeight)
        Me.gbEpPosterOpts.Controls.Add(Me.chkResizeEpPoster)
        Me.gbEpPosterOpts.Controls.Add(Me.chkOverwriteEpPoster)
        Me.gbEpPosterOpts.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.gbEpPosterOpts.Location = New System.Drawing.Point(4, 5)
        Me.gbEpPosterOpts.Name = "gbEpPosterOpts"
        Me.gbEpPosterOpts.Size = New System.Drawing.Size(228, 135)
        Me.gbEpPosterOpts.TabIndex = 0
        Me.gbEpPosterOpts.TabStop = False
        Me.gbEpPosterOpts.Text = "Poster"
        '
        'txtEpPosterWidth
        '
        Me.txtEpPosterWidth.Enabled = False
        Me.txtEpPosterWidth.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEpPosterWidth.Location = New System.Drawing.Point(71, 49)
        Me.txtEpPosterWidth.Name = "txtEpPosterWidth"
        Me.txtEpPosterWidth.Size = New System.Drawing.Size(40, 22)
        Me.txtEpPosterWidth.TabIndex = 3
        '
        'txtEpPosterHeight
        '
        Me.txtEpPosterHeight.Enabled = False
        Me.txtEpPosterHeight.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEpPosterHeight.Location = New System.Drawing.Point(182, 49)
        Me.txtEpPosterHeight.Name = "txtEpPosterHeight"
        Me.txtEpPosterHeight.Size = New System.Drawing.Size(40, 22)
        Me.txtEpPosterHeight.TabIndex = 5
        '
        'lblEpPosterQual
        '
        Me.lblEpPosterQual.AutoSize = True
        Me.lblEpPosterQual.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lblEpPosterQual.Location = New System.Drawing.Point(181, 98)
        Me.lblEpPosterQual.Name = "lblEpPosterQual"
        Me.lblEpPosterQual.Size = New System.Drawing.Size(29, 17)
        Me.lblEpPosterQual.TabIndex = 8
        Me.lblEpPosterQual.Text = "100"
        '
        'tbEpPosterQual
        '
        Me.tbEpPosterQual.AutoSize = False
        Me.tbEpPosterQual.BackColor = System.Drawing.Color.White
        Me.tbEpPosterQual.LargeChange = 10
        Me.tbEpPosterQual.Location = New System.Drawing.Point(5, 91)
        Me.tbEpPosterQual.Maximum = 100
        Me.tbEpPosterQual.Name = "tbEpPosterQual"
        Me.tbEpPosterQual.Size = New System.Drawing.Size(179, 27)
        Me.tbEpPosterQual.TabIndex = 7
        Me.tbEpPosterQual.TickFrequency = 10
        Me.tbEpPosterQual.Value = 100
        '
        'lblEpPosterQ
        '
        Me.lblEpPosterQ.AutoSize = True
        Me.lblEpPosterQ.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEpPosterQ.Location = New System.Drawing.Point(1, 78)
        Me.lblEpPosterQ.Name = "lblEpPosterQ"
        Me.lblEpPosterQ.Size = New System.Drawing.Size(46, 13)
        Me.lblEpPosterQ.TabIndex = 6
        Me.lblEpPosterQ.Text = "Quality:"
        '
        'lblEpPosterWidth
        '
        Me.lblEpPosterWidth.AutoSize = True
        Me.lblEpPosterWidth.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEpPosterWidth.Location = New System.Drawing.Point(3, 53)
        Me.lblEpPosterWidth.Name = "lblEpPosterWidth"
        Me.lblEpPosterWidth.Size = New System.Drawing.Size(66, 13)
        Me.lblEpPosterWidth.TabIndex = 2
        Me.lblEpPosterWidth.Text = "Max Width:"
        '
        'lblEpPosterHeight
        '
        Me.lblEpPosterHeight.AutoSize = True
        Me.lblEpPosterHeight.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEpPosterHeight.Location = New System.Drawing.Point(112, 53)
        Me.lblEpPosterHeight.Name = "lblEpPosterHeight"
        Me.lblEpPosterHeight.Size = New System.Drawing.Size(69, 13)
        Me.lblEpPosterHeight.TabIndex = 4
        Me.lblEpPosterHeight.Text = "Max Height:"
        '
        'chkResizeEpPoster
        '
        Me.chkResizeEpPoster.AutoSize = True
        Me.chkResizeEpPoster.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkResizeEpPoster.Location = New System.Drawing.Point(4, 30)
        Me.chkResizeEpPoster.Name = "chkResizeEpPoster"
        Me.chkResizeEpPoster.Size = New System.Drawing.Size(133, 17)
        Me.chkResizeEpPoster.TabIndex = 1
        Me.chkResizeEpPoster.Text = "Automatically Resize:"
        Me.chkResizeEpPoster.UseVisualStyleBackColor = True
        '
        'chkOverwriteEpPoster
        '
        Me.chkOverwriteEpPoster.AutoSize = True
        Me.chkOverwriteEpPoster.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkOverwriteEpPoster.Location = New System.Drawing.Point(4, 14)
        Me.chkOverwriteEpPoster.Name = "chkOverwriteEpPoster"
        Me.chkOverwriteEpPoster.Size = New System.Drawing.Size(119, 17)
        Me.chkOverwriteEpPoster.TabIndex = 0
        Me.chkOverwriteEpPoster.Text = "Overwrite Existing"
        Me.chkOverwriteEpPoster.UseVisualStyleBackColor = True
        '
        'gbEpFanartOpts
        '
        Me.gbEpFanartOpts.Controls.Add(Me.txtEpFanartWidth)
        Me.gbEpFanartOpts.Controls.Add(Me.txtEpFanartHeight)
        Me.gbEpFanartOpts.Controls.Add(Me.lblEpFanartQual)
        Me.gbEpFanartOpts.Controls.Add(Me.tbEpFanartQual)
        Me.gbEpFanartOpts.Controls.Add(Me.lblEpFanartQ)
        Me.gbEpFanartOpts.Controls.Add(Me.lblEpFanartWidth)
        Me.gbEpFanartOpts.Controls.Add(Me.lblEpFanartHeight)
        Me.gbEpFanartOpts.Controls.Add(Me.chkResizeEpFanart)
        Me.gbEpFanartOpts.Controls.Add(Me.cbEpFanartSize)
        Me.gbEpFanartOpts.Controls.Add(Me.lblEpFanartSize)
        Me.gbEpFanartOpts.Controls.Add(Me.chkOverwriteEpFanart)
        Me.gbEpFanartOpts.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.gbEpFanartOpts.Location = New System.Drawing.Point(238, 5)
        Me.gbEpFanartOpts.Name = "gbEpFanartOpts"
        Me.gbEpFanartOpts.Size = New System.Drawing.Size(228, 167)
        Me.gbEpFanartOpts.TabIndex = 1
        Me.gbEpFanartOpts.TabStop = False
        Me.gbEpFanartOpts.Text = "Fanart"
        '
        'txtEpFanartWidth
        '
        Me.txtEpFanartWidth.Enabled = False
        Me.txtEpFanartWidth.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEpFanartWidth.Location = New System.Drawing.Point(71, 90)
        Me.txtEpFanartWidth.Name = "txtEpFanartWidth"
        Me.txtEpFanartWidth.Size = New System.Drawing.Size(40, 22)
        Me.txtEpFanartWidth.TabIndex = 5
        '
        'txtEpFanartHeight
        '
        Me.txtEpFanartHeight.Enabled = False
        Me.txtEpFanartHeight.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEpFanartHeight.Location = New System.Drawing.Point(182, 90)
        Me.txtEpFanartHeight.Name = "txtEpFanartHeight"
        Me.txtEpFanartHeight.Size = New System.Drawing.Size(40, 22)
        Me.txtEpFanartHeight.TabIndex = 7
        '
        'lblEpFanartQual
        '
        Me.lblEpFanartQual.AutoSize = True
        Me.lblEpFanartQual.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lblEpFanartQual.Location = New System.Drawing.Point(183, 138)
        Me.lblEpFanartQual.Name = "lblEpFanartQual"
        Me.lblEpFanartQual.Size = New System.Drawing.Size(29, 17)
        Me.lblEpFanartQual.TabIndex = 10
        Me.lblEpFanartQual.Text = "100"
        '
        'tbEpFanartQual
        '
        Me.tbEpFanartQual.AutoSize = False
        Me.tbEpFanartQual.BackColor = System.Drawing.Color.White
        Me.tbEpFanartQual.LargeChange = 10
        Me.tbEpFanartQual.Location = New System.Drawing.Point(7, 131)
        Me.tbEpFanartQual.Maximum = 100
        Me.tbEpFanartQual.Name = "tbEpFanartQual"
        Me.tbEpFanartQual.Size = New System.Drawing.Size(180, 27)
        Me.tbEpFanartQual.TabIndex = 9
        Me.tbEpFanartQual.TickFrequency = 10
        Me.tbEpFanartQual.Value = 100
        '
        'lblEpFanartQ
        '
        Me.lblEpFanartQ.AutoSize = True
        Me.lblEpFanartQ.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEpFanartQ.Location = New System.Drawing.Point(3, 118)
        Me.lblEpFanartQ.Name = "lblEpFanartQ"
        Me.lblEpFanartQ.Size = New System.Drawing.Size(46, 13)
        Me.lblEpFanartQ.TabIndex = 8
        Me.lblEpFanartQ.Text = "Quality:"
        '
        'lblEpFanartWidth
        '
        Me.lblEpFanartWidth.AutoSize = True
        Me.lblEpFanartWidth.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEpFanartWidth.Location = New System.Drawing.Point(3, 94)
        Me.lblEpFanartWidth.Name = "lblEpFanartWidth"
        Me.lblEpFanartWidth.Size = New System.Drawing.Size(66, 13)
        Me.lblEpFanartWidth.TabIndex = 4
        Me.lblEpFanartWidth.Text = "Max Width:"
        '
        'lblEpFanartHeight
        '
        Me.lblEpFanartHeight.AutoSize = True
        Me.lblEpFanartHeight.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEpFanartHeight.Location = New System.Drawing.Point(112, 94)
        Me.lblEpFanartHeight.Name = "lblEpFanartHeight"
        Me.lblEpFanartHeight.Size = New System.Drawing.Size(69, 13)
        Me.lblEpFanartHeight.TabIndex = 6
        Me.lblEpFanartHeight.Text = "Max Height:"
        '
        'chkResizeEpFanart
        '
        Me.chkResizeEpFanart.AutoSize = True
        Me.chkResizeEpFanart.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkResizeEpFanart.Location = New System.Drawing.Point(6, 69)
        Me.chkResizeEpFanart.Name = "chkResizeEpFanart"
        Me.chkResizeEpFanart.Size = New System.Drawing.Size(133, 17)
        Me.chkResizeEpFanart.TabIndex = 3
        Me.chkResizeEpFanart.Text = "Automatically Resize:"
        Me.chkResizeEpFanart.UseVisualStyleBackColor = True
        '
        'cbEpFanartSize
        '
        Me.cbEpFanartSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbEpFanartSize.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.cbEpFanartSize.FormattingEnabled = True
        Me.cbEpFanartSize.Location = New System.Drawing.Point(6, 29)
        Me.cbEpFanartSize.Name = "cbEpFanartSize"
        Me.cbEpFanartSize.Size = New System.Drawing.Size(148, 21)
        Me.cbEpFanartSize.TabIndex = 1
        '
        'lblEpFanartSize
        '
        Me.lblEpFanartSize.AutoSize = True
        Me.lblEpFanartSize.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEpFanartSize.Location = New System.Drawing.Point(3, 14)
        Me.lblEpFanartSize.Name = "lblEpFanartSize"
        Me.lblEpFanartSize.Size = New System.Drawing.Size(80, 13)
        Me.lblEpFanartSize.TabIndex = 0
        Me.lblEpFanartSize.Text = "Preferred Size:"
        '
        'chkOverwriteEpFanart
        '
        Me.chkOverwriteEpFanart.AutoSize = True
        Me.chkOverwriteEpFanart.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkOverwriteEpFanart.Location = New System.Drawing.Point(6, 53)
        Me.chkOverwriteEpFanart.Name = "chkOverwriteEpFanart"
        Me.chkOverwriteEpFanart.Size = New System.Drawing.Size(119, 17)
        Me.chkOverwriteEpFanart.TabIndex = 2
        Me.chkOverwriteEpFanart.Text = "Overwrite Existing"
        Me.chkOverwriteEpFanart.UseVisualStyleBackColor = True
        '
        'TabPage8
        '
        Me.TabPage8.Controls.Add(Me.chkGetEnglishImages)
        Me.TabPage8.Controls.Add(Me.chkOnlyTVImagesLanguage)
        Me.TabPage8.Location = New System.Drawing.Point(4, 22)
        Me.TabPage8.Name = "TabPage8"
        Me.TabPage8.Size = New System.Drawing.Size(601, 371)
        Me.TabPage8.TabIndex = 3
        Me.TabPage8.Text = "General"
        Me.TabPage8.UseVisualStyleBackColor = True
        '
        'chkGetEnglishImages
        '
        Me.chkGetEnglishImages.AutoSize = True
        Me.chkGetEnglishImages.Enabled = False
        Me.chkGetEnglishImages.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.chkGetEnglishImages.Location = New System.Drawing.Point(21, 32)
        Me.chkGetEnglishImages.Name = "chkGetEnglishImages"
        Me.chkGetEnglishImages.Size = New System.Drawing.Size(149, 17)
        Me.chkGetEnglishImages.TabIndex = 1
        Me.chkGetEnglishImages.Text = "Also Get English Images"
        Me.chkGetEnglishImages.UseVisualStyleBackColor = True
        '
        'chkOnlyTVImagesLanguage
        '
        Me.chkOnlyTVImagesLanguage.AutoSize = True
        Me.chkOnlyTVImagesLanguage.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.chkOnlyTVImagesLanguage.Location = New System.Drawing.Point(8, 14)
        Me.chkOnlyTVImagesLanguage.Name = "chkOnlyTVImagesLanguage"
        Me.chkOnlyTVImagesLanguage.Size = New System.Drawing.Size(248, 17)
        Me.chkOnlyTVImagesLanguage.TabIndex = 0
        Me.chkOnlyTVImagesLanguage.Text = "Only Get Images for the Selected Language"
        Me.chkOnlyTVImagesLanguage.UseVisualStyleBackColor = True
        '
        'pnlTVScraper
        '
        Me.pnlTVScraper.BackColor = System.Drawing.Color.White
        Me.pnlTVScraper.Controls.Add(Me.gbTVScraperDuration)
        Me.pnlTVScraper.Controls.Add(Me.gbTVScraperGlobalLocks)
        Me.pnlTVScraper.Controls.Add(Me.gbTVScraperMetaData)
        Me.pnlTVScraper.Controls.Add(Me.gbTVScraperOptions)
        Me.pnlTVScraper.Controls.Add(Me.gbTVScraperFields)
        Me.pnlTVScraper.Location = New System.Drawing.Point(900, 900)
        Me.pnlTVScraper.Name = "pnlTVScraper"
        Me.pnlTVScraper.Size = New System.Drawing.Size(635, 435)
        Me.pnlTVScraper.TabIndex = 19
        Me.pnlTVScraper.Visible = False
        '
        'gbTVScraperDuration
        '
        Me.gbTVScraperDuration.Controls.Add(Me.txtEPRuntimeFormat)
        Me.gbTVScraperDuration.Controls.Add(Me.chkUseEPDuration)
        Me.gbTVScraperDuration.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.gbTVScraperDuration.Location = New System.Drawing.Point(5, 368)
        Me.gbTVScraperDuration.Name = "gbTVScraperDuration"
        Me.gbTVScraperDuration.Size = New System.Drawing.Size(200, 64)
        Me.gbTVScraperDuration.TabIndex = 10
        Me.gbTVScraperDuration.TabStop = False
        Me.gbTVScraperDuration.Text = "Duration Format"
        '
        'txtEPRuntimeFormat
        '
        Me.txtEPRuntimeFormat.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEPRuntimeFormat.Location = New System.Drawing.Point(18, 34)
        Me.txtEPRuntimeFormat.Name = "txtEPRuntimeFormat"
        Me.txtEPRuntimeFormat.Size = New System.Drawing.Size(165, 22)
        Me.txtEPRuntimeFormat.TabIndex = 22
        '
        'chkUseEPDuration
        '
        Me.chkUseEPDuration.AutoSize = True
        Me.chkUseEPDuration.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkUseEPDuration.Location = New System.Drawing.Point(5, 15)
        Me.chkUseEPDuration.Name = "chkUseEPDuration"
        Me.chkUseEPDuration.Size = New System.Drawing.Size(158, 17)
        Me.chkUseEPDuration.TabIndex = 8
        Me.chkUseEPDuration.Text = "Use Duration for Runtime"
        Me.chkUseEPDuration.UseVisualStyleBackColor = True
        '
        'gbTVScraperGlobalLocks
        '
        Me.gbTVScraperGlobalLocks.Controls.Add(Me.gbTVScraperEpLocks)
        Me.gbTVScraperGlobalLocks.Controls.Add(Me.gbTVScraperShowLocks)
        Me.gbTVScraperGlobalLocks.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.gbTVScraperGlobalLocks.Location = New System.Drawing.Point(208, 6)
        Me.gbTVScraperGlobalLocks.Name = "gbTVScraperGlobalLocks"
        Me.gbTVScraperGlobalLocks.Size = New System.Drawing.Size(191, 183)
        Me.gbTVScraperGlobalLocks.TabIndex = 1
        Me.gbTVScraperGlobalLocks.TabStop = False
        Me.gbTVScraperGlobalLocks.Text = "Global Locks"
        '
        'gbTVScraperEpLocks
        '
        Me.gbTVScraperEpLocks.Controls.Add(Me.chkEpLockTitle)
        Me.gbTVScraperEpLocks.Controls.Add(Me.chkEpLockRating)
        Me.gbTVScraperEpLocks.Controls.Add(Me.chkEpLockPlot)
        Me.gbTVScraperEpLocks.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.gbTVScraperEpLocks.Location = New System.Drawing.Point(5, 112)
        Me.gbTVScraperEpLocks.Name = "gbTVScraperEpLocks"
        Me.gbTVScraperEpLocks.Size = New System.Drawing.Size(181, 67)
        Me.gbTVScraperEpLocks.TabIndex = 1
        Me.gbTVScraperEpLocks.TabStop = False
        Me.gbTVScraperEpLocks.Text = "Episode"
        '
        'chkEpLockTitle
        '
        Me.chkEpLockTitle.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkEpLockTitle.Location = New System.Drawing.Point(6, 15)
        Me.chkEpLockTitle.Name = "chkEpLockTitle"
        Me.chkEpLockTitle.Size = New System.Drawing.Size(166, 17)
        Me.chkEpLockTitle.TabIndex = 0
        Me.chkEpLockTitle.Text = "Lock Title"
        Me.chkEpLockTitle.UseVisualStyleBackColor = True
        '
        'chkEpLockRating
        '
        Me.chkEpLockRating.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkEpLockRating.Location = New System.Drawing.Point(6, 47)
        Me.chkEpLockRating.Name = "chkEpLockRating"
        Me.chkEpLockRating.Size = New System.Drawing.Size(168, 17)
        Me.chkEpLockRating.TabIndex = 2
        Me.chkEpLockRating.Text = "Lock Rating"
        Me.chkEpLockRating.UseVisualStyleBackColor = True
        '
        'chkEpLockPlot
        '
        Me.chkEpLockPlot.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkEpLockPlot.Location = New System.Drawing.Point(6, 31)
        Me.chkEpLockPlot.Name = "chkEpLockPlot"
        Me.chkEpLockPlot.Size = New System.Drawing.Size(166, 17)
        Me.chkEpLockPlot.TabIndex = 1
        Me.chkEpLockPlot.Text = "Lock Plot"
        Me.chkEpLockPlot.UseVisualStyleBackColor = True
        '
        'gbTVScraperShowLocks
        '
        Me.gbTVScraperShowLocks.Controls.Add(Me.chkShowLockPlot)
        Me.gbTVScraperShowLocks.Controls.Add(Me.chkShowLockGenre)
        Me.gbTVScraperShowLocks.Controls.Add(Me.chkShowLockStudio)
        Me.gbTVScraperShowLocks.Controls.Add(Me.chkShowLockRating)
        Me.gbTVScraperShowLocks.Controls.Add(Me.chkShowLockTitle)
        Me.gbTVScraperShowLocks.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.gbTVScraperShowLocks.Location = New System.Drawing.Point(5, 13)
        Me.gbTVScraperShowLocks.Name = "gbTVScraperShowLocks"
        Me.gbTVScraperShowLocks.Size = New System.Drawing.Size(181, 96)
        Me.gbTVScraperShowLocks.TabIndex = 0
        Me.gbTVScraperShowLocks.TabStop = False
        Me.gbTVScraperShowLocks.Text = "Show"
        '
        'chkShowLockPlot
        '
        Me.chkShowLockPlot.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkShowLockPlot.Location = New System.Drawing.Point(6, 29)
        Me.chkShowLockPlot.Name = "chkShowLockPlot"
        Me.chkShowLockPlot.Size = New System.Drawing.Size(168, 17)
        Me.chkShowLockPlot.TabIndex = 1
        Me.chkShowLockPlot.Text = "Lock Plot"
        Me.chkShowLockPlot.UseVisualStyleBackColor = True
        '
        'chkShowLockGenre
        '
        Me.chkShowLockGenre.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkShowLockGenre.Location = New System.Drawing.Point(6, 61)
        Me.chkShowLockGenre.Name = "chkShowLockGenre"
        Me.chkShowLockGenre.Size = New System.Drawing.Size(168, 17)
        Me.chkShowLockGenre.TabIndex = 3
        Me.chkShowLockGenre.Text = "Lock Genre"
        Me.chkShowLockGenre.UseVisualStyleBackColor = True
        '
        'chkShowLockStudio
        '
        Me.chkShowLockStudio.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkShowLockStudio.Location = New System.Drawing.Point(6, 77)
        Me.chkShowLockStudio.Name = "chkShowLockStudio"
        Me.chkShowLockStudio.Size = New System.Drawing.Size(168, 17)
        Me.chkShowLockStudio.TabIndex = 4
        Me.chkShowLockStudio.Text = "Lock Studio"
        Me.chkShowLockStudio.UseVisualStyleBackColor = True
        '
        'chkShowLockRating
        '
        Me.chkShowLockRating.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkShowLockRating.Location = New System.Drawing.Point(6, 45)
        Me.chkShowLockRating.Name = "chkShowLockRating"
        Me.chkShowLockRating.Size = New System.Drawing.Size(168, 17)
        Me.chkShowLockRating.TabIndex = 2
        Me.chkShowLockRating.Text = "Lock Rating"
        Me.chkShowLockRating.UseVisualStyleBackColor = True
        '
        'chkShowLockTitle
        '
        Me.chkShowLockTitle.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkShowLockTitle.Location = New System.Drawing.Point(6, 13)
        Me.chkShowLockTitle.Name = "chkShowLockTitle"
        Me.chkShowLockTitle.Size = New System.Drawing.Size(168, 17)
        Me.chkShowLockTitle.TabIndex = 0
        Me.chkShowLockTitle.Text = "Lock Title"
        Me.chkShowLockTitle.UseVisualStyleBackColor = True
        '
        'gbTVScraperMetaData
        '
        Me.gbTVScraperMetaData.Controls.Add(Me.gbTVScraperFileType)
        Me.gbTVScraperMetaData.Controls.Add(Me.cboTVMetaDataOverlay)
        Me.gbTVScraperMetaData.Controls.Add(Me.Label50)
        Me.gbTVScraperMetaData.Controls.Add(Me.chkTVScanMetaData)
        Me.gbTVScraperMetaData.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.gbTVScraperMetaData.Location = New System.Drawing.Point(403, 6)
        Me.gbTVScraperMetaData.Name = "gbTVScraperMetaData"
        Me.gbTVScraperMetaData.Size = New System.Drawing.Size(208, 240)
        Me.gbTVScraperMetaData.TabIndex = 2
        Me.gbTVScraperMetaData.TabStop = False
        Me.gbTVScraperMetaData.Text = "Meta Data"
        '
        'gbTVScraperFileType
        '
        Me.gbTVScraperFileType.Controls.Add(Me.lstTVMetaData)
        Me.gbTVScraperFileType.Controls.Add(Me.txtTVDefFIExt)
        Me.gbTVScraperFileType.Controls.Add(Me.Label49)
        Me.gbTVScraperFileType.Controls.Add(Me.btnRemoveTVMetaDataFT)
        Me.gbTVScraperFileType.Controls.Add(Me.btnEditTVMetaDataFT)
        Me.gbTVScraperFileType.Controls.Add(Me.btnNewTVMetaDataFT)
        Me.gbTVScraperFileType.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.gbTVScraperFileType.Location = New System.Drawing.Point(12, 88)
        Me.gbTVScraperFileType.Name = "gbTVScraperFileType"
        Me.gbTVScraperFileType.Size = New System.Drawing.Size(183, 144)
        Me.gbTVScraperFileType.TabIndex = 3
        Me.gbTVScraperFileType.TabStop = False
        Me.gbTVScraperFileType.Text = "Defaults by File Type"
        '
        'lstTVMetaData
        '
        Me.lstTVMetaData.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lstTVMetaData.FormattingEnabled = True
        Me.lstTVMetaData.Location = New System.Drawing.Point(10, 16)
        Me.lstTVMetaData.Name = "lstTVMetaData"
        Me.lstTVMetaData.Size = New System.Drawing.Size(165, 95)
        Me.lstTVMetaData.TabIndex = 0
        '
        'txtTVDefFIExt
        '
        Me.txtTVDefFIExt.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTVDefFIExt.Location = New System.Drawing.Point(73, 116)
        Me.txtTVDefFIExt.Name = "txtTVDefFIExt"
        Me.txtTVDefFIExt.Size = New System.Drawing.Size(35, 22)
        Me.txtTVDefFIExt.TabIndex = 2
        '
        'Label49
        '
        Me.Label49.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label49.Location = New System.Drawing.Point(8, 116)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(66, 19)
        Me.Label49.TabIndex = 1
        Me.Label49.Text = "File Type"
        Me.Label49.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnRemoveTVMetaDataFT
        '
        Me.btnRemoveTVMetaDataFT.Enabled = False
        Me.btnRemoveTVMetaDataFT.Image = CType(resources.GetObject("btnRemoveTVMetaDataFT.Image"), System.Drawing.Image)
        Me.btnRemoveTVMetaDataFT.Location = New System.Drawing.Point(153, 115)
        Me.btnRemoveTVMetaDataFT.Name = "btnRemoveTVMetaDataFT"
        Me.btnRemoveTVMetaDataFT.Size = New System.Drawing.Size(23, 23)
        Me.btnRemoveTVMetaDataFT.TabIndex = 4
        Me.btnRemoveTVMetaDataFT.UseVisualStyleBackColor = True
        '
        'btnEditTVMetaDataFT
        '
        Me.btnEditTVMetaDataFT.Enabled = False
        Me.btnEditTVMetaDataFT.Image = CType(resources.GetObject("btnEditTVMetaDataFT.Image"), System.Drawing.Image)
        Me.btnEditTVMetaDataFT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEditTVMetaDataFT.Location = New System.Drawing.Point(130, 115)
        Me.btnEditTVMetaDataFT.Name = "btnEditTVMetaDataFT"
        Me.btnEditTVMetaDataFT.Size = New System.Drawing.Size(23, 23)
        Me.btnEditTVMetaDataFT.TabIndex = 3
        Me.btnEditTVMetaDataFT.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEditTVMetaDataFT.UseVisualStyleBackColor = True
        '
        'btnNewTVMetaDataFT
        '
        Me.btnNewTVMetaDataFT.Enabled = False
        Me.btnNewTVMetaDataFT.Image = CType(resources.GetObject("btnNewTVMetaDataFT.Image"), System.Drawing.Image)
        Me.btnNewTVMetaDataFT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNewTVMetaDataFT.Location = New System.Drawing.Point(108, 115)
        Me.btnNewTVMetaDataFT.Name = "btnNewTVMetaDataFT"
        Me.btnNewTVMetaDataFT.Size = New System.Drawing.Size(23, 23)
        Me.btnNewTVMetaDataFT.TabIndex = 29
        Me.btnNewTVMetaDataFT.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnNewTVMetaDataFT.UseVisualStyleBackColor = True
        '
        'cboTVMetaDataOverlay
        '
        Me.cboTVMetaDataOverlay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTVMetaDataOverlay.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.cboTVMetaDataOverlay.FormattingEnabled = True
        Me.cboTVMetaDataOverlay.Location = New System.Drawing.Point(13, 62)
        Me.cboTVMetaDataOverlay.Name = "cboTVMetaDataOverlay"
        Me.cboTVMetaDataOverlay.Size = New System.Drawing.Size(182, 21)
        Me.cboTVMetaDataOverlay.Sorted = True
        Me.cboTVMetaDataOverlay.TabIndex = 2
        '
        'Label50
        '
        Me.Label50.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label50.Location = New System.Drawing.Point(4, 35)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(202, 29)
        Me.Label50.TabIndex = 1
        Me.Label50.Text = "Display Overlay if Video Contains an Audio Stream With the Following Language:"
        Me.Label50.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'chkTVScanMetaData
        '
        Me.chkTVScanMetaData.AutoSize = True
        Me.chkTVScanMetaData.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkTVScanMetaData.Location = New System.Drawing.Point(5, 16)
        Me.chkTVScanMetaData.Name = "chkTVScanMetaData"
        Me.chkTVScanMetaData.Size = New System.Drawing.Size(106, 17)
        Me.chkTVScanMetaData.TabIndex = 0
        Me.chkTVScanMetaData.Text = "Scan Meta Data"
        Me.chkTVScanMetaData.UseVisualStyleBackColor = True
        '
        'gbTVScraperOptions
        '
        Me.gbTVScraperOptions.Controls.Add(Me.lblOrdering)
        Me.gbTVScraperOptions.Controls.Add(Me.cbOrdering)
        Me.gbTVScraperOptions.Controls.Add(Me.lblTVUpdate)
        Me.gbTVScraperOptions.Controls.Add(Me.cboTVUpdate)
        Me.gbTVScraperOptions.Controls.Add(Me.lblAPIKey)
        Me.gbTVScraperOptions.Controls.Add(Me.lblTVDBMirror)
        Me.gbTVScraperOptions.Controls.Add(Me.txtAPIKey)
        Me.gbTVScraperOptions.Controls.Add(Me.txtTVDBMirror)
        Me.gbTVScraperOptions.Controls.Add(Me.gbTVScraperLanguage)
        Me.gbTVScraperOptions.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.gbTVScraperOptions.Location = New System.Drawing.Point(5, 6)
        Me.gbTVScraperOptions.Name = "gbTVScraperOptions"
        Me.gbTVScraperOptions.Size = New System.Drawing.Size(200, 359)
        Me.gbTVScraperOptions.TabIndex = 0
        Me.gbTVScraperOptions.TabStop = False
        Me.gbTVScraperOptions.Text = "Options"
        '
        'lblOrdering
        '
        Me.lblOrdering.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lblOrdering.Location = New System.Drawing.Point(12, 284)
        Me.lblOrdering.Name = "lblOrdering"
        Me.lblOrdering.Size = New System.Drawing.Size(177, 13)
        Me.lblOrdering.TabIndex = 7
        Me.lblOrdering.Text = "Default Episode Ordering:"
        Me.lblOrdering.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'cbOrdering
        '
        Me.cbOrdering.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbOrdering.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.cbOrdering.FormattingEnabled = True
        Me.cbOrdering.Location = New System.Drawing.Point(17, 304)
        Me.cbOrdering.Name = "cbOrdering"
        Me.cbOrdering.Size = New System.Drawing.Size(166, 21)
        Me.cbOrdering.TabIndex = 8
        '
        'lblTVUpdate
        '
        Me.lblTVUpdate.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTVUpdate.Location = New System.Drawing.Point(5, 217)
        Me.lblTVUpdate.Name = "lblTVUpdate"
        Me.lblTVUpdate.Size = New System.Drawing.Size(190, 31)
        Me.lblTVUpdate.TabIndex = 5
        Me.lblTVUpdate.Text = "Re-download Show Information Every:"
        Me.lblTVUpdate.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'cboTVUpdate
        '
        Me.cboTVUpdate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTVUpdate.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.cboTVUpdate.FormattingEnabled = True
        Me.cboTVUpdate.Location = New System.Drawing.Point(17, 248)
        Me.cboTVUpdate.Name = "cboTVUpdate"
        Me.cboTVUpdate.Size = New System.Drawing.Size(166, 21)
        Me.cboTVUpdate.TabIndex = 6
        '
        'lblAPIKey
        '
        Me.lblAPIKey.AutoSize = True
        Me.lblAPIKey.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAPIKey.Location = New System.Drawing.Point(4, 60)
        Me.lblAPIKey.Name = "lblAPIKey"
        Me.lblAPIKey.Size = New System.Drawing.Size(73, 13)
        Me.lblAPIKey.TabIndex = 2
        Me.lblAPIKey.Text = "TVDB APIKey:"
        '
        'lblTVDBMirror
        '
        Me.lblTVDBMirror.AutoSize = True
        Me.lblTVDBMirror.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTVDBMirror.Location = New System.Drawing.Point(4, 17)
        Me.lblTVDBMirror.Name = "lblTVDBMirror"
        Me.lblTVDBMirror.Size = New System.Drawing.Size(72, 13)
        Me.lblTVDBMirror.TabIndex = 0
        Me.lblTVDBMirror.Text = "TVDB Mirror:"
        '
        'txtAPIKey
        '
        Me.txtAPIKey.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAPIKey.Location = New System.Drawing.Point(6, 75)
        Me.txtAPIKey.Name = "txtAPIKey"
        Me.txtAPIKey.Size = New System.Drawing.Size(189, 22)
        Me.txtAPIKey.TabIndex = 3
        '
        'txtTVDBMirror
        '
        Me.txtTVDBMirror.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTVDBMirror.Location = New System.Drawing.Point(6, 32)
        Me.txtTVDBMirror.Name = "txtTVDBMirror"
        Me.txtTVDBMirror.Size = New System.Drawing.Size(189, 22)
        Me.txtTVDBMirror.TabIndex = 1
        '
        'gbTVScraperLanguage
        '
        Me.gbTVScraperLanguage.Controls.Add(Me.lblTVLanguagePreferred)
        Me.gbTVScraperLanguage.Controls.Add(Me.btnTVLanguageFetch)
        Me.gbTVScraperLanguage.Controls.Add(Me.cbTVLanguage)
        Me.gbTVScraperLanguage.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.gbTVScraperLanguage.Location = New System.Drawing.Point(5, 104)
        Me.gbTVScraperLanguage.Name = "gbTVScraperLanguage"
        Me.gbTVScraperLanguage.Size = New System.Drawing.Size(190, 100)
        Me.gbTVScraperLanguage.TabIndex = 4
        Me.gbTVScraperLanguage.TabStop = False
        Me.gbTVScraperLanguage.Text = "Language"
        '
        'lblTVLanguagePreferred
        '
        Me.lblTVLanguagePreferred.AutoSize = True
        Me.lblTVLanguagePreferred.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTVLanguagePreferred.Location = New System.Drawing.Point(10, 24)
        Me.lblTVLanguagePreferred.Name = "lblTVLanguagePreferred"
        Me.lblTVLanguagePreferred.Size = New System.Drawing.Size(111, 13)
        Me.lblTVLanguagePreferred.TabIndex = 0
        Me.lblTVLanguagePreferred.Text = "Preferred Language:"
        '
        'btnTVLanguageFetch
        '
        Me.btnTVLanguageFetch.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.btnTVLanguageFetch.Location = New System.Drawing.Point(12, 68)
        Me.btnTVLanguageFetch.Name = "btnTVLanguageFetch"
        Me.btnTVLanguageFetch.Size = New System.Drawing.Size(166, 23)
        Me.btnTVLanguageFetch.TabIndex = 2
        Me.btnTVLanguageFetch.Text = "Fetch Available Languages"
        Me.btnTVLanguageFetch.UseVisualStyleBackColor = True
        '
        'cbTVLanguage
        '
        Me.cbTVLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTVLanguage.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.cbTVLanguage.Location = New System.Drawing.Point(12, 39)
        Me.cbTVLanguage.Name = "cbTVLanguage"
        Me.cbTVLanguage.Size = New System.Drawing.Size(166, 21)
        Me.cbTVLanguage.TabIndex = 1
        '
        'gbTVScraperFields
        '
        Me.gbTVScraperFields.Controls.Add(Me.gbTVScraperShow)
        Me.gbTVScraperFields.Controls.Add(Me.gbTVScraperEpisode)
        Me.gbTVScraperFields.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.gbTVScraperFields.Location = New System.Drawing.Point(208, 246)
        Me.gbTVScraperFields.Name = "gbTVScraperFields"
        Me.gbTVScraperFields.Size = New System.Drawing.Size(403, 185)
        Me.gbTVScraperFields.TabIndex = 3
        Me.gbTVScraperFields.TabStop = False
        Me.gbTVScraperFields.Text = "Scraper Fields"
        '
        'gbTVScraperShow
        '
        Me.gbTVScraperShow.Controls.Add(Me.chkScraperShowRating)
        Me.gbTVScraperShow.Controls.Add(Me.chkScraperShowActors)
        Me.gbTVScraperShow.Controls.Add(Me.chkScraperShowStudio)
        Me.gbTVScraperShow.Controls.Add(Me.chkScraperShowPremiered)
        Me.gbTVScraperShow.Controls.Add(Me.chkScraperShowEGU)
        Me.gbTVScraperShow.Controls.Add(Me.chkScraperShowMPAA)
        Me.gbTVScraperShow.Controls.Add(Me.chkScraperShowPlot)
        Me.gbTVScraperShow.Controls.Add(Me.chkScraperShowGenre)
        Me.gbTVScraperShow.Controls.Add(Me.chkScraperShowTitle)
        Me.gbTVScraperShow.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.gbTVScraperShow.Location = New System.Drawing.Point(3, 14)
        Me.gbTVScraperShow.Name = "gbTVScraperShow"
        Me.gbTVScraperShow.Size = New System.Drawing.Size(188, 165)
        Me.gbTVScraperShow.TabIndex = 0
        Me.gbTVScraperShow.TabStop = False
        Me.gbTVScraperShow.Text = "Show"
        '
        'chkScraperShowRating
        '
        Me.chkScraperShowRating.AutoSize = True
        Me.chkScraperShowRating.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkScraperShowRating.Location = New System.Drawing.Point(6, 109)
        Me.chkScraperShowRating.Name = "chkScraperShowRating"
        Me.chkScraperShowRating.Size = New System.Drawing.Size(60, 17)
        Me.chkScraperShowRating.TabIndex = 6
        Me.chkScraperShowRating.Text = "Rating"
        Me.chkScraperShowRating.UseVisualStyleBackColor = True
        '
        'chkScraperShowActors
        '
        Me.chkScraperShowActors.AutoSize = True
        Me.chkScraperShowActors.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkScraperShowActors.Location = New System.Drawing.Point(6, 141)
        Me.chkScraperShowActors.Name = "chkScraperShowActors"
        Me.chkScraperShowActors.Size = New System.Drawing.Size(58, 17)
        Me.chkScraperShowActors.TabIndex = 8
        Me.chkScraperShowActors.Text = "Actors"
        Me.chkScraperShowActors.UseVisualStyleBackColor = True
        '
        'chkScraperShowStudio
        '
        Me.chkScraperShowStudio.AutoSize = True
        Me.chkScraperShowStudio.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkScraperShowStudio.Location = New System.Drawing.Point(6, 125)
        Me.chkScraperShowStudio.Name = "chkScraperShowStudio"
        Me.chkScraperShowStudio.Size = New System.Drawing.Size(60, 17)
        Me.chkScraperShowStudio.TabIndex = 7
        Me.chkScraperShowStudio.Text = "Studio"
        Me.chkScraperShowStudio.UseVisualStyleBackColor = True
        '
        'chkScraperShowPremiered
        '
        Me.chkScraperShowPremiered.AutoSize = True
        Me.chkScraperShowPremiered.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkScraperShowPremiered.Location = New System.Drawing.Point(6, 93)
        Me.chkScraperShowPremiered.Margin = New System.Windows.Forms.Padding(3, 0, 3, 0)
        Me.chkScraperShowPremiered.Name = "chkScraperShowPremiered"
        Me.chkScraperShowPremiered.Size = New System.Drawing.Size(77, 17)
        Me.chkScraperShowPremiered.TabIndex = 5
        Me.chkScraperShowPremiered.Text = "Premiered"
        Me.chkScraperShowPremiered.UseVisualStyleBackColor = True
        '
        'chkScraperShowEGU
        '
        Me.chkScraperShowEGU.AutoSize = True
        Me.chkScraperShowEGU.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkScraperShowEGU.Location = New System.Drawing.Point(6, 29)
        Me.chkScraperShowEGU.Name = "chkScraperShowEGU"
        Me.chkScraperShowEGU.Size = New System.Drawing.Size(118, 17)
        Me.chkScraperShowEGU.TabIndex = 1
        Me.chkScraperShowEGU.Text = "EpisodeGuideURL"
        Me.chkScraperShowEGU.UseVisualStyleBackColor = True
        '
        'chkScraperShowMPAA
        '
        Me.chkScraperShowMPAA.AutoSize = True
        Me.chkScraperShowMPAA.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkScraperShowMPAA.Location = New System.Drawing.Point(6, 61)
        Me.chkScraperShowMPAA.Name = "chkScraperShowMPAA"
        Me.chkScraperShowMPAA.Size = New System.Drawing.Size(56, 17)
        Me.chkScraperShowMPAA.TabIndex = 3
        Me.chkScraperShowMPAA.Text = "MPAA"
        Me.chkScraperShowMPAA.UseVisualStyleBackColor = True
        '
        'chkScraperShowPlot
        '
        Me.chkScraperShowPlot.AutoSize = True
        Me.chkScraperShowPlot.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkScraperShowPlot.Location = New System.Drawing.Point(6, 77)
        Me.chkScraperShowPlot.Name = "chkScraperShowPlot"
        Me.chkScraperShowPlot.Size = New System.Drawing.Size(46, 17)
        Me.chkScraperShowPlot.TabIndex = 4
        Me.chkScraperShowPlot.Text = "Plot"
        Me.chkScraperShowPlot.UseVisualStyleBackColor = True
        '
        'chkScraperShowGenre
        '
        Me.chkScraperShowGenre.AutoSize = True
        Me.chkScraperShowGenre.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkScraperShowGenre.Location = New System.Drawing.Point(6, 45)
        Me.chkScraperShowGenre.Name = "chkScraperShowGenre"
        Me.chkScraperShowGenre.Size = New System.Drawing.Size(57, 17)
        Me.chkScraperShowGenre.TabIndex = 2
        Me.chkScraperShowGenre.Text = "Genre"
        Me.chkScraperShowGenre.UseVisualStyleBackColor = True
        '
        'chkScraperShowTitle
        '
        Me.chkScraperShowTitle.AutoSize = True
        Me.chkScraperShowTitle.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkScraperShowTitle.Location = New System.Drawing.Point(6, 13)
        Me.chkScraperShowTitle.Name = "chkScraperShowTitle"
        Me.chkScraperShowTitle.Size = New System.Drawing.Size(47, 17)
        Me.chkScraperShowTitle.TabIndex = 0
        Me.chkScraperShowTitle.Text = "Title"
        Me.chkScraperShowTitle.UseVisualStyleBackColor = True
        '
        'gbTVScraperEpisode
        '
        Me.gbTVScraperEpisode.Controls.Add(Me.chkScraperEpActors)
        Me.gbTVScraperEpisode.Controls.Add(Me.chkScraperEpCredits)
        Me.gbTVScraperEpisode.Controls.Add(Me.chkScraperEpDirector)
        Me.gbTVScraperEpisode.Controls.Add(Me.chkScraperEpPlot)
        Me.gbTVScraperEpisode.Controls.Add(Me.chkScraperEpRating)
        Me.gbTVScraperEpisode.Controls.Add(Me.chkScraperEpAired)
        Me.gbTVScraperEpisode.Controls.Add(Me.chkScraperEpTitle)
        Me.gbTVScraperEpisode.Controls.Add(Me.chkScraperEpEpisode)
        Me.gbTVScraperEpisode.Controls.Add(Me.chkScraperEpSeason)
        Me.gbTVScraperEpisode.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.gbTVScraperEpisode.Location = New System.Drawing.Point(197, 14)
        Me.gbTVScraperEpisode.Name = "gbTVScraperEpisode"
        Me.gbTVScraperEpisode.Size = New System.Drawing.Size(200, 165)
        Me.gbTVScraperEpisode.TabIndex = 1
        Me.gbTVScraperEpisode.TabStop = False
        Me.gbTVScraperEpisode.Text = "Episode"
        '
        'chkScraperEpActors
        '
        Me.chkScraperEpActors.AutoSize = True
        Me.chkScraperEpActors.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkScraperEpActors.Location = New System.Drawing.Point(6, 141)
        Me.chkScraperEpActors.Name = "chkScraperEpActors"
        Me.chkScraperEpActors.Size = New System.Drawing.Size(58, 17)
        Me.chkScraperEpActors.TabIndex = 0
        Me.chkScraperEpActors.Text = "Actors"
        Me.chkScraperEpActors.UseVisualStyleBackColor = True
        '
        'chkScraperEpCredits
        '
        Me.chkScraperEpCredits.AutoSize = True
        Me.chkScraperEpCredits.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkScraperEpCredits.Location = New System.Drawing.Point(6, 125)
        Me.chkScraperEpCredits.Name = "chkScraperEpCredits"
        Me.chkScraperEpCredits.Size = New System.Drawing.Size(62, 17)
        Me.chkScraperEpCredits.TabIndex = 8
        Me.chkScraperEpCredits.Text = "Credits"
        Me.chkScraperEpCredits.UseVisualStyleBackColor = True
        '
        'chkScraperEpDirector
        '
        Me.chkScraperEpDirector.AutoSize = True
        Me.chkScraperEpDirector.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkScraperEpDirector.Location = New System.Drawing.Point(6, 109)
        Me.chkScraperEpDirector.Name = "chkScraperEpDirector"
        Me.chkScraperEpDirector.Size = New System.Drawing.Size(67, 17)
        Me.chkScraperEpDirector.TabIndex = 7
        Me.chkScraperEpDirector.Text = "Director"
        Me.chkScraperEpDirector.UseVisualStyleBackColor = True
        '
        'chkScraperEpPlot
        '
        Me.chkScraperEpPlot.AutoSize = True
        Me.chkScraperEpPlot.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkScraperEpPlot.Location = New System.Drawing.Point(6, 93)
        Me.chkScraperEpPlot.Name = "chkScraperEpPlot"
        Me.chkScraperEpPlot.Size = New System.Drawing.Size(46, 17)
        Me.chkScraperEpPlot.TabIndex = 6
        Me.chkScraperEpPlot.Text = "Plot"
        Me.chkScraperEpPlot.UseVisualStyleBackColor = True
        '
        'chkScraperEpRating
        '
        Me.chkScraperEpRating.AutoSize = True
        Me.chkScraperEpRating.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkScraperEpRating.Location = New System.Drawing.Point(6, 77)
        Me.chkScraperEpRating.Name = "chkScraperEpRating"
        Me.chkScraperEpRating.Size = New System.Drawing.Size(60, 17)
        Me.chkScraperEpRating.TabIndex = 5
        Me.chkScraperEpRating.Text = "Rating"
        Me.chkScraperEpRating.UseVisualStyleBackColor = True
        '
        'chkScraperEpAired
        '
        Me.chkScraperEpAired.AutoSize = True
        Me.chkScraperEpAired.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkScraperEpAired.Location = New System.Drawing.Point(6, 61)
        Me.chkScraperEpAired.Name = "chkScraperEpAired"
        Me.chkScraperEpAired.Size = New System.Drawing.Size(53, 17)
        Me.chkScraperEpAired.TabIndex = 4
        Me.chkScraperEpAired.Text = "Aired"
        Me.chkScraperEpAired.UseVisualStyleBackColor = True
        '
        'chkScraperEpTitle
        '
        Me.chkScraperEpTitle.AutoSize = True
        Me.chkScraperEpTitle.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkScraperEpTitle.Location = New System.Drawing.Point(6, 13)
        Me.chkScraperEpTitle.Name = "chkScraperEpTitle"
        Me.chkScraperEpTitle.Size = New System.Drawing.Size(47, 17)
        Me.chkScraperEpTitle.TabIndex = 0
        Me.chkScraperEpTitle.Text = "Title"
        Me.chkScraperEpTitle.UseVisualStyleBackColor = True
        '
        'chkScraperEpEpisode
        '
        Me.chkScraperEpEpisode.AutoSize = True
        Me.chkScraperEpEpisode.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkScraperEpEpisode.Location = New System.Drawing.Point(6, 45)
        Me.chkScraperEpEpisode.Name = "chkScraperEpEpisode"
        Me.chkScraperEpEpisode.Size = New System.Drawing.Size(67, 17)
        Me.chkScraperEpEpisode.TabIndex = 3
        Me.chkScraperEpEpisode.Text = "Episode"
        Me.chkScraperEpEpisode.UseVisualStyleBackColor = True
        '
        'chkScraperEpSeason
        '
        Me.chkScraperEpSeason.AutoSize = True
        Me.chkScraperEpSeason.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkScraperEpSeason.Location = New System.Drawing.Point(6, 29)
        Me.chkScraperEpSeason.Name = "chkScraperEpSeason"
        Me.chkScraperEpSeason.Size = New System.Drawing.Size(63, 17)
        Me.chkScraperEpSeason.TabIndex = 2
        Me.chkScraperEpSeason.Text = "Season"
        Me.chkScraperEpSeason.UseVisualStyleBackColor = True
        '
        'pnlMain
        '
        Me.pnlMain.AutoScroll = True
        Me.pnlMain.BackColor = System.Drawing.Color.White
        Me.pnlMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlMain.Location = New System.Drawing.Point(251, 147)
        Me.pnlMain.Name = "pnlMain"
        Me.pnlMain.Size = New System.Drawing.Size(640, 440)
        Me.pnlMain.TabIndex = 9
        '
        'gbScraperFields
        '
        Me.gbScraperFields.Controls.Add(Me.chkCertification)
        Me.gbScraperFields.Controls.Add(Me.chkTop250)
        Me.gbScraperFields.Controls.Add(Me.chkCountry)
        Me.gbScraperFields.Controls.Add(Me.txtGenreLimit)
        Me.gbScraperFields.Controls.Add(Me.lblLimit2)
        Me.gbScraperFields.Controls.Add(Me.txtActorLimit)
        Me.gbScraperFields.Controls.Add(Me.lblLimit)
        Me.gbScraperFields.Controls.Add(Me.chkCrew)
        Me.gbScraperFields.Controls.Add(Me.chkMusicBy)
        Me.gbScraperFields.Controls.Add(Me.chkProducers)
        Me.gbScraperFields.Controls.Add(Me.chkWriters)
        Me.gbScraperFields.Controls.Add(Me.chkStudio)
        Me.gbScraperFields.Controls.Add(Me.chkRuntime)
        Me.gbScraperFields.Controls.Add(Me.chkPlot)
        Me.gbScraperFields.Controls.Add(Me.chkOutline)
        Me.gbScraperFields.Controls.Add(Me.chkGenre)
        Me.gbScraperFields.Controls.Add(Me.chkDirector)
        Me.gbScraperFields.Controls.Add(Me.chkTagline)
        Me.gbScraperFields.Controls.Add(Me.chkCast)
        Me.gbScraperFields.Controls.Add(Me.chkVotes)
        Me.gbScraperFields.Controls.Add(Me.chkTrailer)
        Me.gbScraperFields.Controls.Add(Me.chkRating)
        Me.gbScraperFields.Controls.Add(Me.chkRelease)
        Me.gbScraperFields.Controls.Add(Me.chkMPAA)
        Me.gbScraperFields.Controls.Add(Me.chkYear)
        Me.gbScraperFields.Controls.Add(Me.chkTitle)
        Me.gbScraperFields.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.gbScraperFields.Location = New System.Drawing.Point(8, 236)
        Me.gbScraperFields.Name = "gbScraperFields"
        Me.gbScraperFields.Size = New System.Drawing.Size(322, 185)
        Me.gbScraperFields.TabIndex = 67
        Me.gbScraperFields.TabStop = False
        Me.gbScraperFields.Text = "Scraper Fields - Global"
        '
        'chkCertification
        '
        Me.chkCertification.AutoSize = True
        Me.chkCertification.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkCertification.Location = New System.Drawing.Point(6, 76)
        Me.chkCertification.Name = "chkCertification"
        Me.chkCertification.Size = New System.Drawing.Size(89, 17)
        Me.chkCertification.TabIndex = 24
        Me.chkCertification.Text = "Certification"
        Me.chkCertification.UseVisualStyleBackColor = True
        '
        'chkTop250
        '
        Me.chkTop250.AutoSize = True
        Me.chkTop250.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkTop250.Location = New System.Drawing.Point(205, 133)
        Me.chkTop250.Name = "chkTop250"
        Me.chkTop250.Size = New System.Drawing.Size(66, 17)
        Me.chkTop250.TabIndex = 23
        Me.chkTop250.Text = "Top 250"
        Me.chkTop250.UseVisualStyleBackColor = True
        '
        'chkCountry
        '
        Me.chkCountry.AutoSize = True
        Me.chkCountry.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkCountry.Location = New System.Drawing.Point(205, 152)
        Me.chkCountry.Name = "chkCountry"
        Me.chkCountry.Size = New System.Drawing.Size(67, 17)
        Me.chkCountry.TabIndex = 25
        Me.chkCountry.Text = "Country"
        Me.chkCountry.UseVisualStyleBackColor = True
        '
        'txtGenreLimit
        '
        Me.txtGenreLimit.Enabled = False
        Me.txtGenreLimit.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGenreLimit.Location = New System.Drawing.Point(255, 55)
        Me.txtGenreLimit.Name = "txtGenreLimit"
        Me.txtGenreLimit.Size = New System.Drawing.Size(39, 22)
        Me.txtGenreLimit.TabIndex = 21
        '
        'lblLimit2
        '
        Me.lblLimit2.AutoSize = True
        Me.lblLimit2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLimit2.Location = New System.Drawing.Point(223, 58)
        Me.lblLimit2.Name = "lblLimit2"
        Me.lblLimit2.Size = New System.Drawing.Size(34, 13)
        Me.lblLimit2.TabIndex = 22
        Me.lblLimit2.Text = "Limit:"
        Me.lblLimit2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtActorLimit
        '
        Me.txtActorLimit.Enabled = False
        Me.txtActorLimit.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtActorLimit.Location = New System.Drawing.Point(151, 112)
        Me.txtActorLimit.Name = "txtActorLimit"
        Me.txtActorLimit.Size = New System.Drawing.Size(39, 22)
        Me.txtActorLimit.TabIndex = 19
        '
        'lblLimit
        '
        Me.lblLimit.AutoSize = True
        Me.lblLimit.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLimit.Location = New System.Drawing.Point(118, 115)
        Me.lblLimit.Name = "lblLimit"
        Me.lblLimit.Size = New System.Drawing.Size(34, 13)
        Me.lblLimit.TabIndex = 20
        Me.lblLimit.Text = "Limit:"
        Me.lblLimit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'chkCrew
        '
        Me.chkCrew.AutoSize = True
        Me.chkCrew.Enabled = False
        Me.chkCrew.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkCrew.Location = New System.Drawing.Point(205, 114)
        Me.chkCrew.Name = "chkCrew"
        Me.chkCrew.Size = New System.Drawing.Size(85, 17)
        Me.chkCrew.TabIndex = 18
        Me.chkCrew.Text = "Other Crew"
        Me.chkCrew.UseVisualStyleBackColor = True
        '
        'chkMusicBy
        '
        Me.chkMusicBy.AutoSize = True
        Me.chkMusicBy.Enabled = False
        Me.chkMusicBy.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkMusicBy.Location = New System.Drawing.Point(205, 95)
        Me.chkMusicBy.Name = "chkMusicBy"
        Me.chkMusicBy.Size = New System.Drawing.Size(71, 17)
        Me.chkMusicBy.TabIndex = 17
        Me.chkMusicBy.Text = "Music By"
        Me.chkMusicBy.UseVisualStyleBackColor = True
        '
        'chkProducers
        '
        Me.chkProducers.AutoSize = True
        Me.chkProducers.Enabled = False
        Me.chkProducers.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkProducers.Location = New System.Drawing.Point(205, 19)
        Me.chkProducers.Name = "chkProducers"
        Me.chkProducers.Size = New System.Drawing.Size(77, 17)
        Me.chkProducers.TabIndex = 16
        Me.chkProducers.Text = "Producers"
        Me.chkProducers.UseVisualStyleBackColor = True
        '
        'chkWriters
        '
        Me.chkWriters.AutoSize = True
        Me.chkWriters.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkWriters.Location = New System.Drawing.Point(101, 152)
        Me.chkWriters.Name = "chkWriters"
        Me.chkWriters.Size = New System.Drawing.Size(63, 17)
        Me.chkWriters.TabIndex = 15
        Me.chkWriters.Text = "Writers"
        Me.chkWriters.UseVisualStyleBackColor = True
        '
        'chkStudio
        '
        Me.chkStudio.AutoSize = True
        Me.chkStudio.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkStudio.Location = New System.Drawing.Point(101, 19)
        Me.chkStudio.Name = "chkStudio"
        Me.chkStudio.Size = New System.Drawing.Size(60, 17)
        Me.chkStudio.TabIndex = 14
        Me.chkStudio.Text = "Studio"
        Me.chkStudio.UseVisualStyleBackColor = True
        '
        'chkRuntime
        '
        Me.chkRuntime.AutoSize = True
        Me.chkRuntime.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkRuntime.Location = New System.Drawing.Point(6, 114)
        Me.chkRuntime.Name = "chkRuntime"
        Me.chkRuntime.Size = New System.Drawing.Size(69, 17)
        Me.chkRuntime.TabIndex = 13
        Me.chkRuntime.Text = "Runtime"
        Me.chkRuntime.UseVisualStyleBackColor = True
        '
        'chkPlot
        '
        Me.chkPlot.AutoSize = True
        Me.chkPlot.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkPlot.Location = New System.Drawing.Point(101, 76)
        Me.chkPlot.Name = "chkPlot"
        Me.chkPlot.Size = New System.Drawing.Size(46, 17)
        Me.chkPlot.TabIndex = 12
        Me.chkPlot.Text = "Plot"
        Me.chkPlot.UseVisualStyleBackColor = True
        '
        'chkOutline
        '
        Me.chkOutline.AutoSize = True
        Me.chkOutline.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkOutline.Location = New System.Drawing.Point(101, 57)
        Me.chkOutline.Name = "chkOutline"
        Me.chkOutline.Size = New System.Drawing.Size(65, 17)
        Me.chkOutline.TabIndex = 11
        Me.chkOutline.Text = "Outline"
        Me.chkOutline.UseVisualStyleBackColor = True
        '
        'chkGenre
        '
        Me.chkGenre.AutoSize = True
        Me.chkGenre.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkGenre.Location = New System.Drawing.Point(205, 38)
        Me.chkGenre.Name = "chkGenre"
        Me.chkGenre.Size = New System.Drawing.Size(57, 17)
        Me.chkGenre.TabIndex = 10
        Me.chkGenre.Text = "Genre"
        Me.chkGenre.UseVisualStyleBackColor = True
        '
        'chkDirector
        '
        Me.chkDirector.AutoSize = True
        Me.chkDirector.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkDirector.Location = New System.Drawing.Point(101, 133)
        Me.chkDirector.Name = "chkDirector"
        Me.chkDirector.Size = New System.Drawing.Size(67, 17)
        Me.chkDirector.TabIndex = 9
        Me.chkDirector.Text = "Director"
        Me.chkDirector.UseVisualStyleBackColor = True
        '
        'chkTagline
        '
        Me.chkTagline.AutoSize = True
        Me.chkTagline.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkTagline.Location = New System.Drawing.Point(101, 38)
        Me.chkTagline.Name = "chkTagline"
        Me.chkTagline.Size = New System.Drawing.Size(63, 17)
        Me.chkTagline.TabIndex = 8
        Me.chkTagline.Text = "Tagline"
        Me.chkTagline.UseVisualStyleBackColor = True
        '
        'chkCast
        '
        Me.chkCast.AutoSize = True
        Me.chkCast.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkCast.Location = New System.Drawing.Point(101, 95)
        Me.chkCast.Name = "chkCast"
        Me.chkCast.Size = New System.Drawing.Size(48, 17)
        Me.chkCast.TabIndex = 7
        Me.chkCast.Text = "Cast"
        Me.chkCast.UseVisualStyleBackColor = True
        '
        'chkVotes
        '
        Me.chkVotes.AutoSize = True
        Me.chkVotes.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkVotes.Location = New System.Drawing.Point(6, 152)
        Me.chkVotes.Name = "chkVotes"
        Me.chkVotes.Size = New System.Drawing.Size(55, 17)
        Me.chkVotes.TabIndex = 6
        Me.chkVotes.Text = "Votes"
        Me.chkVotes.UseVisualStyleBackColor = True
        '
        'chkTrailer
        '
        Me.chkTrailer.AutoSize = True
        Me.chkTrailer.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkTrailer.Location = New System.Drawing.Point(205, 76)
        Me.chkTrailer.Name = "chkTrailer"
        Me.chkTrailer.Size = New System.Drawing.Size(57, 17)
        Me.chkTrailer.TabIndex = 5
        Me.chkTrailer.Text = "Trailer"
        Me.chkTrailer.UseVisualStyleBackColor = True
        '
        'chkRating
        '
        Me.chkRating.AutoSize = True
        Me.chkRating.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkRating.Location = New System.Drawing.Point(6, 133)
        Me.chkRating.Name = "chkRating"
        Me.chkRating.Size = New System.Drawing.Size(60, 17)
        Me.chkRating.TabIndex = 4
        Me.chkRating.Text = "Rating"
        Me.chkRating.UseVisualStyleBackColor = True
        '
        'chkRelease
        '
        Me.chkRelease.AutoSize = True
        Me.chkRelease.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkRelease.Location = New System.Drawing.Point(6, 95)
        Me.chkRelease.Name = "chkRelease"
        Me.chkRelease.Size = New System.Drawing.Size(92, 17)
        Me.chkRelease.TabIndex = 3
        Me.chkRelease.Text = "Release Date"
        Me.chkRelease.UseVisualStyleBackColor = True
        '
        'chkMPAA
        '
        Me.chkMPAA.AutoSize = True
        Me.chkMPAA.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkMPAA.Location = New System.Drawing.Point(6, 57)
        Me.chkMPAA.Name = "chkMPAA"
        Me.chkMPAA.Size = New System.Drawing.Size(56, 17)
        Me.chkMPAA.TabIndex = 2
        Me.chkMPAA.Text = "MPAA"
        Me.chkMPAA.UseVisualStyleBackColor = True
        '
        'chkYear
        '
        Me.chkYear.AutoSize = True
        Me.chkYear.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkYear.Location = New System.Drawing.Point(6, 38)
        Me.chkYear.Name = "chkYear"
        Me.chkYear.Size = New System.Drawing.Size(47, 17)
        Me.chkYear.TabIndex = 1
        Me.chkYear.Text = "Year"
        Me.chkYear.UseVisualStyleBackColor = True
        '
        'chkTitle
        '
        Me.chkTitle.AutoSize = True
        Me.chkTitle.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkTitle.Location = New System.Drawing.Point(6, 19)
        Me.chkTitle.Name = "chkTitle"
        Me.chkTitle.Size = New System.Drawing.Size(47, 17)
        Me.chkTitle.TabIndex = 0
        Me.chkTitle.Text = "Title"
        Me.chkTitle.UseVisualStyleBackColor = True
        '
        'gbScraperMetaData
        '
        Me.gbScraperMetaData.Controls.Add(Me.gbScraperFileType)
        Me.gbScraperMetaData.Controls.Add(Me.chkIFOScan)
        Me.gbScraperMetaData.Controls.Add(Me.cbLanguages)
        Me.gbScraperMetaData.Controls.Add(Me.Label31)
        Me.gbScraperMetaData.Controls.Add(Me.gbScraperDurationFormat)
        Me.gbScraperMetaData.Controls.Add(Me.chkScanMediaInfo)
        Me.gbScraperMetaData.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.gbScraperMetaData.Location = New System.Drawing.Point(170, 6)
        Me.gbScraperMetaData.Name = "gbScraperMetaData"
        Me.gbScraperMetaData.Size = New System.Drawing.Size(455, 176)
        Me.gbScraperMetaData.TabIndex = 63
        Me.gbScraperMetaData.TabStop = False
        Me.gbScraperMetaData.Text = "Meta Data"
        '
        'gbScraperFileType
        '
        Me.gbScraperFileType.Controls.Add(Me.lstMetaData)
        Me.gbScraperFileType.Controls.Add(Me.txtDefFIExt)
        Me.gbScraperFileType.Controls.Add(Me.Label34)
        Me.gbScraperFileType.Controls.Add(Me.btnRemoveMetaDataFT)
        Me.gbScraperFileType.Controls.Add(Me.btnEditMetaDataFT)
        Me.gbScraperFileType.Controls.Add(Me.btnNewMetaDataFT)
        Me.gbScraperFileType.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.gbScraperFileType.Location = New System.Drawing.Point(266, 8)
        Me.gbScraperFileType.Name = "gbScraperFileType"
        Me.gbScraperFileType.Size = New System.Drawing.Size(183, 144)
        Me.gbScraperFileType.TabIndex = 8
        Me.gbScraperFileType.TabStop = False
        Me.gbScraperFileType.Text = "Defaults by File Type"
        '
        'lstMetaData
        '
        Me.lstMetaData.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lstMetaData.FormattingEnabled = True
        Me.lstMetaData.Location = New System.Drawing.Point(9, 15)
        Me.lstMetaData.Name = "lstMetaData"
        Me.lstMetaData.Size = New System.Drawing.Size(165, 95)
        Me.lstMetaData.TabIndex = 34
        '
        'txtDefFIExt
        '
        Me.txtDefFIExt.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDefFIExt.Location = New System.Drawing.Point(72, 115)
        Me.txtDefFIExt.Name = "txtDefFIExt"
        Me.txtDefFIExt.Size = New System.Drawing.Size(35, 22)
        Me.txtDefFIExt.TabIndex = 33
        '
        'Label34
        '
        Me.Label34.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.Location = New System.Drawing.Point(7, 118)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(63, 19)
        Me.Label34.TabIndex = 32
        Me.Label34.Text = "File Type:"
        Me.Label34.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnRemoveMetaDataFT
        '
        Me.btnRemoveMetaDataFT.Enabled = False
        Me.btnRemoveMetaDataFT.Image = CType(resources.GetObject("btnRemoveMetaDataFT.Image"), System.Drawing.Image)
        Me.btnRemoveMetaDataFT.Location = New System.Drawing.Point(152, 114)
        Me.btnRemoveMetaDataFT.Name = "btnRemoveMetaDataFT"
        Me.btnRemoveMetaDataFT.Size = New System.Drawing.Size(23, 23)
        Me.btnRemoveMetaDataFT.TabIndex = 31
        Me.btnRemoveMetaDataFT.UseVisualStyleBackColor = True
        '
        'btnEditMetaDataFT
        '
        Me.btnEditMetaDataFT.Enabled = False
        Me.btnEditMetaDataFT.Image = CType(resources.GetObject("btnEditMetaDataFT.Image"), System.Drawing.Image)
        Me.btnEditMetaDataFT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEditMetaDataFT.Location = New System.Drawing.Point(129, 114)
        Me.btnEditMetaDataFT.Name = "btnEditMetaDataFT"
        Me.btnEditMetaDataFT.Size = New System.Drawing.Size(23, 23)
        Me.btnEditMetaDataFT.TabIndex = 30
        Me.btnEditMetaDataFT.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEditMetaDataFT.UseVisualStyleBackColor = True
        '
        'btnNewMetaDataFT
        '
        Me.btnNewMetaDataFT.Enabled = False
        Me.btnNewMetaDataFT.Image = CType(resources.GetObject("btnNewMetaDataFT.Image"), System.Drawing.Image)
        Me.btnNewMetaDataFT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNewMetaDataFT.Location = New System.Drawing.Point(107, 114)
        Me.btnNewMetaDataFT.Name = "btnNewMetaDataFT"
        Me.btnNewMetaDataFT.Size = New System.Drawing.Size(23, 23)
        Me.btnNewMetaDataFT.TabIndex = 29
        Me.btnNewMetaDataFT.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnNewMetaDataFT.UseVisualStyleBackColor = True
        '
        'chkIFOScan
        '
        Me.chkIFOScan.AutoSize = True
        Me.chkIFOScan.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkIFOScan.Location = New System.Drawing.Point(6, 33)
        Me.chkIFOScan.Name = "chkIFOScan"
        Me.chkIFOScan.Size = New System.Drawing.Size(123, 17)
        Me.chkIFOScan.TabIndex = 18
        Me.chkIFOScan.Text = "Enable IFO Parsing"
        Me.chkIFOScan.UseVisualStyleBackColor = True
        '
        'cbLanguages
        '
        Me.cbLanguages.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbLanguages.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.cbLanguages.FormattingEnabled = True
        Me.cbLanguages.Location = New System.Drawing.Point(38, 147)
        Me.cbLanguages.Name = "cbLanguages"
        Me.cbLanguages.Size = New System.Drawing.Size(174, 21)
        Me.cbLanguages.Sorted = True
        Me.cbLanguages.TabIndex = 17
        '
        'Label31
        '
        Me.Label31.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.Location = New System.Drawing.Point(2, 117)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(245, 29)
        Me.Label31.TabIndex = 16
        Me.Label31.Text = "Display Overlay if Video Contains an Audio Stream With the Following Language:"
        Me.Label31.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'gbScraperDurationFormat
        '
        Me.gbScraperDurationFormat.Controls.Add(Me.Label51)
        Me.gbScraperDurationFormat.Controls.Add(Me.txtRuntimeFormat)
        Me.gbScraperDurationFormat.Controls.Add(Me.chkUseMIDuration)
        Me.gbScraperDurationFormat.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.gbScraperDurationFormat.Location = New System.Drawing.Point(6, 50)
        Me.gbScraperDurationFormat.Name = "gbScraperDurationFormat"
        Me.gbScraperDurationFormat.Size = New System.Drawing.Size(254, 64)
        Me.gbScraperDurationFormat.TabIndex = 9
        Me.gbScraperDurationFormat.TabStop = False
        Me.gbScraperDurationFormat.Text = "Duration Format"
        '
        'Label51
        '
        Me.Label51.Font = New System.Drawing.Font("Segoe UI", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label51.Location = New System.Drawing.Point(169, 15)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(79, 41)
        Me.Label51.TabIndex = 23
        Me.Label51.Text = "<h>=Hours" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "<m>=Minutes" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "<s>=Seconds"
        Me.Label51.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtRuntimeFormat
        '
        Me.txtRuntimeFormat.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRuntimeFormat.Location = New System.Drawing.Point(5, 34)
        Me.txtRuntimeFormat.Name = "txtRuntimeFormat"
        Me.txtRuntimeFormat.Size = New System.Drawing.Size(145, 22)
        Me.txtRuntimeFormat.TabIndex = 22
        '
        'chkUseMIDuration
        '
        Me.chkUseMIDuration.AutoSize = True
        Me.chkUseMIDuration.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkUseMIDuration.Location = New System.Drawing.Point(5, 15)
        Me.chkUseMIDuration.Name = "chkUseMIDuration"
        Me.chkUseMIDuration.Size = New System.Drawing.Size(158, 17)
        Me.chkUseMIDuration.TabIndex = 8
        Me.chkUseMIDuration.Text = "Use Duration for Runtime"
        Me.chkUseMIDuration.UseVisualStyleBackColor = True
        '
        'chkScanMediaInfo
        '
        Me.chkScanMediaInfo.AutoSize = True
        Me.chkScanMediaInfo.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkScanMediaInfo.Location = New System.Drawing.Point(6, 16)
        Me.chkScanMediaInfo.Name = "chkScanMediaInfo"
        Me.chkScanMediaInfo.Size = New System.Drawing.Size(106, 17)
        Me.chkScanMediaInfo.TabIndex = 7
        Me.chkScanMediaInfo.Text = "Scan Meta Data"
        Me.chkScanMediaInfo.UseVisualStyleBackColor = True
        '
        'gbScraperGlobalLocks
        '
        Me.gbScraperGlobalLocks.Controls.Add(Me.chkLockSubtitle)
        Me.gbScraperGlobalLocks.Controls.Add(Me.chkLockMPAA)
        Me.gbScraperGlobalLocks.Controls.Add(Me.chkLockLanguageA)
        Me.gbScraperGlobalLocks.Controls.Add(Me.chkLockLanguageV)
        Me.gbScraperGlobalLocks.Controls.Add(Me.chkLockOutline)
        Me.gbScraperGlobalLocks.Controls.Add(Me.chkLockPlot)
        Me.gbScraperGlobalLocks.Controls.Add(Me.chkLockTrailer)
        Me.gbScraperGlobalLocks.Controls.Add(Me.chkLockGenre)
        Me.gbScraperGlobalLocks.Controls.Add(Me.chkLockRealStudio)
        Me.gbScraperGlobalLocks.Controls.Add(Me.chkLockRating)
        Me.gbScraperGlobalLocks.Controls.Add(Me.chkLockTagline)
        Me.gbScraperGlobalLocks.Controls.Add(Me.chkLockTitle)
        Me.gbScraperGlobalLocks.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.gbScraperGlobalLocks.Location = New System.Drawing.Point(8, 6)
        Me.gbScraperGlobalLocks.Name = "gbScraperGlobalLocks"
        Me.gbScraperGlobalLocks.Size = New System.Drawing.Size(156, 224)
        Me.gbScraperGlobalLocks.TabIndex = 1
        Me.gbScraperGlobalLocks.TabStop = False
        Me.gbScraperGlobalLocks.Text = "Global Locks"
        '
        'chkLockSubtitle
        '
        Me.chkLockSubtitle.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkLockSubtitle.Location = New System.Drawing.Point(6, 203)
        Me.chkLockSubtitle.Name = "chkLockSubtitle"
        Me.chkLockSubtitle.Size = New System.Drawing.Size(129, 17)
        Me.chkLockSubtitle.TabIndex = 50
        Me.chkLockSubtitle.Text = "Lock Subtitle"
        Me.chkLockSubtitle.UseVisualStyleBackColor = True
        '
        'chkLockMPAA
        '
        Me.chkLockMPAA.AutoSize = True
        Me.chkLockMPAA.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkLockMPAA.Location = New System.Drawing.Point(6, 186)
        Me.chkLockMPAA.Name = "chkLockMPAA"
        Me.chkLockMPAA.Size = New System.Drawing.Size(149, 17)
        Me.chkLockMPAA.TabIndex = 49
        Me.chkLockMPAA.Text = "Lock MPAA/Certification"
        Me.chkLockMPAA.UseVisualStyleBackColor = True
        '
        'chkLockLanguageA
        '
        Me.chkLockLanguageA.AutoSize = True
        Me.chkLockLanguageA.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkLockLanguageA.Location = New System.Drawing.Point(6, 169)
        Me.chkLockLanguageA.Name = "chkLockLanguageA"
        Me.chkLockLanguageA.Size = New System.Drawing.Size(142, 17)
        Me.chkLockLanguageA.TabIndex = 48
        Me.chkLockLanguageA.Text = "Lock Language (audio)"
        Me.chkLockLanguageA.UseVisualStyleBackColor = True
        '
        'chkLockLanguageV
        '
        Me.chkLockLanguageV.AutoSize = True
        Me.chkLockLanguageV.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkLockLanguageV.Location = New System.Drawing.Point(6, 152)
        Me.chkLockLanguageV.Name = "chkLockLanguageV"
        Me.chkLockLanguageV.Size = New System.Drawing.Size(140, 17)
        Me.chkLockLanguageV.TabIndex = 47
        Me.chkLockLanguageV.Text = "Lock Language (video)"
        Me.chkLockLanguageV.UseVisualStyleBackColor = True
        '
        'chkLockOutline
        '
        Me.chkLockOutline.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkLockOutline.Location = New System.Drawing.Point(6, 50)
        Me.chkLockOutline.Name = "chkLockOutline"
        Me.chkLockOutline.Size = New System.Drawing.Size(129, 17)
        Me.chkLockOutline.TabIndex = 1
        Me.chkLockOutline.Text = "Lock Outline"
        Me.chkLockOutline.UseVisualStyleBackColor = True
        '
        'chkLockPlot
        '
        Me.chkLockPlot.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkLockPlot.Location = New System.Drawing.Point(6, 33)
        Me.chkLockPlot.Name = "chkLockPlot"
        Me.chkLockPlot.Size = New System.Drawing.Size(76, 17)
        Me.chkLockPlot.TabIndex = 0
        Me.chkLockPlot.Text = "Lock Plot"
        Me.chkLockPlot.UseVisualStyleBackColor = True
        '
        'chkLockTrailer
        '
        Me.chkLockTrailer.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkLockTrailer.Location = New System.Drawing.Point(6, 135)
        Me.chkLockTrailer.Name = "chkLockTrailer"
        Me.chkLockTrailer.Size = New System.Drawing.Size(129, 17)
        Me.chkLockTrailer.TabIndex = 46
        Me.chkLockTrailer.Text = "Lock Trailer"
        Me.chkLockTrailer.UseVisualStyleBackColor = True
        '
        'chkLockGenre
        '
        Me.chkLockGenre.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkLockGenre.Location = New System.Drawing.Point(6, 118)
        Me.chkLockGenre.Name = "chkLockGenre"
        Me.chkLockGenre.Size = New System.Drawing.Size(129, 17)
        Me.chkLockGenre.TabIndex = 7
        Me.chkLockGenre.Text = "Lock Genre"
        Me.chkLockGenre.UseVisualStyleBackColor = True
        '
        'chkLockRealStudio
        '
        Me.chkLockRealStudio.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkLockRealStudio.Location = New System.Drawing.Point(6, 101)
        Me.chkLockRealStudio.Name = "chkLockRealStudio"
        Me.chkLockRealStudio.Size = New System.Drawing.Size(129, 17)
        Me.chkLockRealStudio.TabIndex = 5
        Me.chkLockRealStudio.Text = "Lock Studio"
        Me.chkLockRealStudio.UseVisualStyleBackColor = True
        '
        'chkLockRating
        '
        Me.chkLockRating.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkLockRating.Location = New System.Drawing.Point(6, 84)
        Me.chkLockRating.Name = "chkLockRating"
        Me.chkLockRating.Size = New System.Drawing.Size(129, 17)
        Me.chkLockRating.TabIndex = 4
        Me.chkLockRating.Text = "Lock Rating"
        Me.chkLockRating.UseVisualStyleBackColor = True
        '
        'chkLockTagline
        '
        Me.chkLockTagline.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkLockTagline.Location = New System.Drawing.Point(6, 67)
        Me.chkLockTagline.Name = "chkLockTagline"
        Me.chkLockTagline.Size = New System.Drawing.Size(129, 17)
        Me.chkLockTagline.TabIndex = 3
        Me.chkLockTagline.Text = "Lock Tagline"
        Me.chkLockTagline.UseVisualStyleBackColor = True
        '
        'chkLockTitle
        '
        Me.chkLockTitle.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkLockTitle.Location = New System.Drawing.Point(6, 16)
        Me.chkLockTitle.Name = "chkLockTitle"
        Me.chkLockTitle.Size = New System.Drawing.Size(129, 17)
        Me.chkLockTitle.TabIndex = 2
        Me.chkLockTitle.Text = "Lock Title"
        Me.chkLockTitle.UseVisualStyleBackColor = True
        '
        'gbScraperMiscellaneous
        '
        Me.gbScraperMiscellaneous.Controls.Add(Me.txtOutlineLimit)
        Me.gbScraperMiscellaneous.Controls.Add(Me.chkPlotForOutline)
        Me.gbScraperMiscellaneous.Controls.Add(Me.chkUseMPAAFSK)
        Me.gbScraperMiscellaneous.Controls.Add(Me.chkOnlyValueForCert)
        Me.gbScraperMiscellaneous.Controls.Add(Me.cbForce)
        Me.gbScraperMiscellaneous.Controls.Add(Me.chkForceTitle)
        Me.gbScraperMiscellaneous.Controls.Add(Me.chkOutlineForPlot)
        Me.gbScraperMiscellaneous.Controls.Add(Me.chkCastWithImg)
        Me.gbScraperMiscellaneous.Controls.Add(Me.chkUseCertForMPAA)
        Me.gbScraperMiscellaneous.Controls.Add(Me.chkFullCast)
        Me.gbScraperMiscellaneous.Controls.Add(Me.chkFullCrew)
        Me.gbScraperMiscellaneous.Controls.Add(Me.cbCert)
        Me.gbScraperMiscellaneous.Controls.Add(Me.chkCert)
        Me.gbScraperMiscellaneous.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.gbScraperMiscellaneous.Location = New System.Drawing.Point(336, 188)
        Me.gbScraperMiscellaneous.Name = "gbScraperMiscellaneous"
        Me.gbScraperMiscellaneous.Size = New System.Drawing.Size(289, 233)
        Me.gbScraperMiscellaneous.TabIndex = 0
        Me.gbScraperMiscellaneous.TabStop = False
        Me.gbScraperMiscellaneous.Text = "Miscellaneous"
        '
        'txtOutlineLimit
        '
        Me.txtOutlineLimit.Enabled = False
        Me.txtOutlineLimit.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtOutlineLimit.Location = New System.Drawing.Point(233, 80)
        Me.txtOutlineLimit.Name = "txtOutlineLimit"
        Me.txtOutlineLimit.Size = New System.Drawing.Size(50, 22)
        Me.txtOutlineLimit.TabIndex = 69
        '
        'chkPlotForOutline
        '
        Me.chkPlotForOutline.AutoSize = True
        Me.chkPlotForOutline.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkPlotForOutline.Location = New System.Drawing.Point(6, 82)
        Me.chkPlotForOutline.Name = "chkPlotForOutline"
        Me.chkPlotForOutline.Size = New System.Drawing.Size(225, 17)
        Me.chkPlotForOutline.TabIndex = 68
        Me.chkPlotForOutline.Text = "Use Plot for Outline if Outline is Empty"
        Me.chkPlotForOutline.UseVisualStyleBackColor = True
        '
        'chkUseMPAAFSK
        '
        Me.chkUseMPAAFSK.AutoSize = True
        Me.chkUseMPAAFSK.Enabled = False
        Me.chkUseMPAAFSK.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkUseMPAAFSK.Location = New System.Drawing.Point(25, 185)
        Me.chkUseMPAAFSK.Name = "chkUseMPAAFSK"
        Me.chkUseMPAAFSK.Size = New System.Drawing.Size(213, 17)
        Me.chkUseMPAAFSK.TabIndex = 67
        Me.chkUseMPAAFSK.Text = "Use MPAA as Fallback for FSK Rating"
        Me.chkUseMPAAFSK.UseVisualStyleBackColor = True
        '
        'chkOnlyValueForCert
        '
        Me.chkOnlyValueForCert.AutoSize = True
        Me.chkOnlyValueForCert.Enabled = False
        Me.chkOnlyValueForCert.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkOnlyValueForCert.Location = New System.Drawing.Point(25, 164)
        Me.chkOnlyValueForCert.Name = "chkOnlyValueForCert"
        Me.chkOnlyValueForCert.Size = New System.Drawing.Size(168, 17)
        Me.chkOnlyValueForCert.TabIndex = 66
        Me.chkOnlyValueForCert.Text = "Only Save the Value to NFO"
        Me.chkOnlyValueForCert.UseVisualStyleBackColor = True
        '
        'cbForce
        '
        Me.cbForce.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbForce.Enabled = False
        Me.cbForce.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.cbForce.FormattingEnabled = True
        Me.cbForce.Location = New System.Drawing.Point(139, 205)
        Me.cbForce.Name = "cbForce"
        Me.cbForce.Size = New System.Drawing.Size(144, 21)
        Me.cbForce.Sorted = True
        Me.cbForce.TabIndex = 65
        '
        'chkForceTitle
        '
        Me.chkForceTitle.AutoSize = True
        Me.chkForceTitle.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkForceTitle.Location = New System.Drawing.Point(6, 206)
        Me.chkForceTitle.Name = "chkForceTitle"
        Me.chkForceTitle.Size = New System.Drawing.Size(135, 17)
        Me.chkForceTitle.TabIndex = 64
        Me.chkForceTitle.Text = "Force Title Language:"
        Me.chkForceTitle.UseVisualStyleBackColor = True
        '
        'chkOutlineForPlot
        '
        Me.chkOutlineForPlot.AutoSize = True
        Me.chkOutlineForPlot.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkOutlineForPlot.Location = New System.Drawing.Point(6, 101)
        Me.chkOutlineForPlot.Name = "chkOutlineForPlot"
        Me.chkOutlineForPlot.Size = New System.Drawing.Size(206, 17)
        Me.chkOutlineForPlot.TabIndex = 3
        Me.chkOutlineForPlot.Text = "Use Outline for Plot if Plot is Empty"
        Me.chkOutlineForPlot.UseVisualStyleBackColor = True
        '
        'chkCastWithImg
        '
        Me.chkCastWithImg.AutoSize = True
        Me.chkCastWithImg.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkCastWithImg.Location = New System.Drawing.Point(6, 40)
        Me.chkCastWithImg.Name = "chkCastWithImg"
        Me.chkCastWithImg.Size = New System.Drawing.Size(189, 17)
        Me.chkCastWithImg.TabIndex = 1
        Me.chkCastWithImg.Text = "Scrape Only Actors With Images"
        Me.chkCastWithImg.UseVisualStyleBackColor = True
        '
        'chkUseCertForMPAA
        '
        Me.chkUseCertForMPAA.AutoSize = True
        Me.chkUseCertForMPAA.Enabled = False
        Me.chkUseCertForMPAA.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkUseCertForMPAA.Location = New System.Drawing.Point(6, 146)
        Me.chkUseCertForMPAA.Name = "chkUseCertForMPAA"
        Me.chkUseCertForMPAA.Size = New System.Drawing.Size(162, 17)
        Me.chkUseCertForMPAA.TabIndex = 6
        Me.chkUseCertForMPAA.Text = "Use Certification for MPAA"
        Me.chkUseCertForMPAA.UseVisualStyleBackColor = True
        '
        'chkFullCast
        '
        Me.chkFullCast.AutoSize = True
        Me.chkFullCast.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkFullCast.Location = New System.Drawing.Point(6, 19)
        Me.chkFullCast.Name = "chkFullCast"
        Me.chkFullCast.Size = New System.Drawing.Size(107, 17)
        Me.chkFullCast.TabIndex = 0
        Me.chkFullCast.Text = "Scrape Full Cast"
        Me.chkFullCast.UseVisualStyleBackColor = True
        '
        'chkFullCrew
        '
        Me.chkFullCrew.AutoSize = True
        Me.chkFullCrew.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkFullCrew.Location = New System.Drawing.Point(6, 61)
        Me.chkFullCrew.Name = "chkFullCrew"
        Me.chkFullCrew.Size = New System.Drawing.Size(111, 17)
        Me.chkFullCrew.TabIndex = 2
        Me.chkFullCrew.Text = "Scrape Full Crew"
        Me.chkFullCrew.UseVisualStyleBackColor = True
        '
        'cbCert
        '
        Me.cbCert.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbCert.Enabled = False
        Me.cbCert.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.cbCert.FormattingEnabled = True
        Me.cbCert.Items.AddRange(New Object() {"Argentina", "Australia", "Belgium", "Brazil", "Canada", "Finland", "France", "Germany", "Hong Kong", "Hungary", "Iceland", "Ireland", "Netherlands", "New Zealand", "Peru", "Poland", "Portugal", "Serbia", "Singapore", "South Korea", "Spain", "Sweden", "Switzerland", "Turkey", "UK", "USA"})
        Me.cbCert.Location = New System.Drawing.Point(175, 124)
        Me.cbCert.Name = "cbCert"
        Me.cbCert.Size = New System.Drawing.Size(108, 21)
        Me.cbCert.Sorted = True
        Me.cbCert.TabIndex = 5
        '
        'chkCert
        '
        Me.chkCert.AutoSize = True
        Me.chkCert.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkCert.Location = New System.Drawing.Point(6, 125)
        Me.chkCert.Name = "chkCert"
        Me.chkCert.Size = New System.Drawing.Size(168, 17)
        Me.chkCert.TabIndex = 4
        Me.chkCert.Text = "Use Certification Language:"
        Me.chkCert.UseVisualStyleBackColor = True
        '
        'pnlScraper
        '
        Me.pnlScraper.BackColor = System.Drawing.Color.White
        Me.pnlScraper.Controls.Add(Me.gbScraperGlobalLocks)
        Me.pnlScraper.Controls.Add(Me.gbScraperFields)
        Me.pnlScraper.Controls.Add(Me.gbScraperMiscellaneous)
        Me.pnlScraper.Controls.Add(Me.gbScraperMetaData)
        Me.pnlScraper.Location = New System.Drawing.Point(900, 900)
        Me.pnlScraper.Name = "pnlScraper"
        Me.pnlScraper.Size = New System.Drawing.Size(635, 435)
        Me.pnlScraper.TabIndex = 14
        Me.pnlScraper.Visible = False
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AllowMerge = False
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.ToolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 64)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(894, 25)
        Me.ToolStrip1.Stretch = True
        Me.ToolStrip1.TabIndex = 4
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'gbHelp
        '
        Me.gbHelp.BackColor = System.Drawing.Color.White
        Me.gbHelp.Controls.Add(Me.PictureBox2)
        Me.gbHelp.Controls.Add(Me.lblHelp)
        Me.gbHelp.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbHelp.Location = New System.Drawing.Point(3, 3)
        Me.gbHelp.Name = "gbHelp"
        Me.gbHelp.Size = New System.Drawing.Size(628, 62)
        Me.gbHelp.TabIndex = 0
        Me.gbHelp.TabStop = False
        Me.gbHelp.Text = "     Help"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(6, -2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(16, 16)
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'lblHelp
        '
        Me.lblHelp.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHelp.Location = New System.Drawing.Point(3, 14)
        Me.lblHelp.Name = "lblHelp"
        Me.lblHelp.Size = New System.Drawing.Size(622, 43)
        Me.lblHelp.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.gbHelp)
        Me.Panel2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel2.Location = New System.Drawing.Point(5, 592)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(636, 69)
        Me.Panel2.TabIndex = 8
        '
        'dlgSettings
        '
        Me.AcceptButton = Me.btnOK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(894, 666)
        Me.Controls.Add(Me.pnlTVScraper)
        Me.Controls.Add(Me.pnlGeneral)
        Me.Controls.Add(Me.pnlShows)
        Me.Controls.Add(Me.pnlSources)
        Me.Controls.Add(Me.pnlTVSources)
        Me.Controls.Add(Me.pnlImages)
        Me.Controls.Add(Me.pnlScraper)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.pnlCurrent)
        Me.Controls.Add(Me.tvSettings)
        Me.Controls.Add(Me.pnlTop)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnApply)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.pnlMovies)
        Me.Controls.Add(Me.pnlTVImages)
        Me.Controls.Add(Me.pnlExtensions)
        Me.Controls.Add(Me.pnlXBMCCom)
        Me.Controls.Add(Me.pnlMain)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgSettings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "ss"
        Me.gbGeneralMiscellaneous.ResumeLayout(False)
        Me.gbGeneralMiscellaneous.PerformLayout()
        Me.GroupBox29.ResumeLayout(False)
        Me.GroupBox29.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.tcCleaner.ResumeLayout(False)
        Me.tpStandard.ResumeLayout(False)
        Me.tpStandard.PerformLayout()
        Me.tpExpert.ResumeLayout(False)
        Me.tpExpert.PerformLayout()
        Me.gbMoviesMiscellaneous.ResumeLayout(False)
        Me.gbMoviesMiscellaneous.PerformLayout()
        Me.gbMoviesMediaList.ResumeLayout(False)
        Me.gbMoviesMediaList.PerformLayout()
        Me.gbMoviesSortToken.ResumeLayout(False)
        Me.gbMoviesSortToken.PerformLayout()
        Me.gbSourcesFileNaming.ResumeLayout(False)
        Me.GroupBox21.ResumeLayout(False)
        Me.GroupBox21.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.gbImagesPoster.ResumeLayout(False)
        Me.gbImagesPoster.PerformLayout()
        CType(Me.tbPosterQual, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbImagesFanart.ResumeLayout(False)
        Me.gbImagesFanart.PerformLayout()
        CType(Me.tbFanartQual, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbImagesImages.ResumeLayout(False)
        Me.gbImagesCaching.ResumeLayout(False)
        Me.gbImagesCaching.PerformLayout()
        Me.pnlTop.ResumeLayout(False)
        Me.pnlTop.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlGeneral.ResumeLayout(False)
        Me.gbGeneralInterface.ResumeLayout(False)
        Me.gbGeneralInterface.PerformLayout()
        Me.pnlXBMCCom.ResumeLayout(False)
        Me.gbProxy.ResumeLayout(False)
        Me.gbProxy.PerformLayout()
        Me.gbCreds.ResumeLayout(False)
        Me.gbCreds.PerformLayout()
        Me.pnlMovies.ResumeLayout(False)
        Me.gbMoviesGenreFilter.ResumeLayout(False)
        Me.gbMoviesFilters.ResumeLayout(False)
        Me.gbMoviesFilters.PerformLayout()
        Me.gbMoviesMissingFilter.ResumeLayout(False)
        Me.gbSourcesBackdrops.ResumeLayout(False)
        Me.gbSourcesBackdrops.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.pbCurrent, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlExtensions.ResumeLayout(False)
        Me.GroupBox22.ResumeLayout(False)
        Me.GroupBox22.PerformLayout()
        Me.GroupBox18.ResumeLayout(False)
        Me.GroupBox18.PerformLayout()
        Me.pnlSources.ResumeLayout(False)
        Me.gbSourcesMiscellaneous.ResumeLayout(False)
        Me.gbSourcesMiscellaneous.PerformLayout()
        Me.pnlImages.ResumeLayout(False)
        Me.gbImagesTrailers.ResumeLayout(False)
        Me.gbImagesTrailers.PerformLayout()
        Me.gbImagesExtrathumbs.ResumeLayout(False)
        Me.gbImagesExtrathumbs.PerformLayout()
        Me.gbImagesSizing.ResumeLayout(False)
        Me.gbImagesSizing.PerformLayout()
        Me.pnlTVSources.ResumeLayout(False)
        Me.TabControl2.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.gbMiscTVSourceOpts.ResumeLayout(False)
        Me.gbMiscTVSourceOpts.PerformLayout()
        Me.gbTVNaming.ResumeLayout(False)
        Me.gbShowBanner.ResumeLayout(False)
        Me.gbShowBanner.PerformLayout()
        Me.gbAllSeasonPoster.ResumeLayout(False)
        Me.gbAllSeasonPoster.PerformLayout()
        Me.gbEpisodeFanart.ResumeLayout(False)
        Me.gbEpisodeFanart.PerformLayout()
        Me.gbEpisodePosters.ResumeLayout(False)
        Me.gbEpisodePosters.PerformLayout()
        Me.gbSeasonFanart.ResumeLayout(False)
        Me.gbSeasonFanart.PerformLayout()
        Me.gbSeasonPosters.ResumeLayout(False)
        Me.gbSeasonPosters.PerformLayout()
        Me.gbShowFanart.ResumeLayout(False)
        Me.gbShowFanart.PerformLayout()
        Me.gbShowPosters.ResumeLayout(False)
        Me.gbShowPosters.PerformLayout()
        Me.TabPage4.ResumeLayout(False)
        Me.gbShowRegex.ResumeLayout(False)
        Me.gbShowRegex.PerformLayout()
        Me.pnlShows.ResumeLayout(False)
        Me.gbShowMediaList.ResumeLayout(False)
        Me.gbShowMediaList.PerformLayout()
        Me.gbEpisodeListOptions.ResumeLayout(False)
        Me.gbEpisodeListOptions.PerformLayout()
        Me.gbSeasonListOptions.ResumeLayout(False)
        Me.gbSeasonListOptions.PerformLayout()
        Me.gbShowListOptions.ResumeLayout(False)
        Me.gbShowListOptions.PerformLayout()
        Me.gbShowsMiscellaneous.ResumeLayout(False)
        Me.gbShowsMiscellaneous.PerformLayout()
        Me.gbShowEpFilter.ResumeLayout(False)
        Me.gbShowEpFilter.PerformLayout()
        Me.gbShowFilter.ResumeLayout(False)
        Me.gbShowFilter.PerformLayout()
        Me.pnlTVImages.ResumeLayout(False)
        Me.TabControl3.ResumeLayout(False)
        Me.TabPage5.ResumeLayout(False)
        Me.gbAllSPosterOpts.ResumeLayout(False)
        Me.gbAllSPosterOpts.PerformLayout()
        CType(Me.tbAllSPosterQual, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbShowPosterOpts.ResumeLayout(False)
        Me.gbShowPosterOpts.PerformLayout()
        CType(Me.tbShowPosterQual, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbShowFanartOpts.ResumeLayout(False)
        Me.gbShowFanartOpts.PerformLayout()
        CType(Me.tbShowFanartQual, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage6.ResumeLayout(False)
        Me.gbSeaPosterOpts.ResumeLayout(False)
        Me.gbSeaPosterOpts.PerformLayout()
        CType(Me.tbSeaPosterQual, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbSeaFanartOpts.ResumeLayout(False)
        Me.gbSeaFanartOpts.PerformLayout()
        CType(Me.tbSeaFanartQual, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage7.ResumeLayout(False)
        Me.gbEpPosterOpts.ResumeLayout(False)
        Me.gbEpPosterOpts.PerformLayout()
        CType(Me.tbEpPosterQual, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbEpFanartOpts.ResumeLayout(False)
        Me.gbEpFanartOpts.PerformLayout()
        CType(Me.tbEpFanartQual, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage8.ResumeLayout(False)
        Me.TabPage8.PerformLayout()
        Me.pnlTVScraper.ResumeLayout(False)
        Me.gbTVScraperDuration.ResumeLayout(False)
        Me.gbTVScraperDuration.PerformLayout()
        Me.gbTVScraperGlobalLocks.ResumeLayout(False)
        Me.gbTVScraperEpLocks.ResumeLayout(False)
        Me.gbTVScraperShowLocks.ResumeLayout(False)
        Me.gbTVScraperMetaData.ResumeLayout(False)
        Me.gbTVScraperMetaData.PerformLayout()
        Me.gbTVScraperFileType.ResumeLayout(False)
        Me.gbTVScraperFileType.PerformLayout()
        Me.gbTVScraperOptions.ResumeLayout(False)
        Me.gbTVScraperOptions.PerformLayout()
        Me.gbTVScraperLanguage.ResumeLayout(False)
        Me.gbTVScraperLanguage.PerformLayout()
        Me.gbTVScraperFields.ResumeLayout(False)
        Me.gbTVScraperShow.ResumeLayout(False)
        Me.gbTVScraperShow.PerformLayout()
        Me.gbTVScraperEpisode.ResumeLayout(False)
        Me.gbTVScraperEpisode.PerformLayout()
        Me.gbScraperFields.ResumeLayout(False)
        Me.gbScraperFields.PerformLayout()
        Me.gbScraperMetaData.ResumeLayout(False)
        Me.gbScraperMetaData.PerformLayout()
        Me.gbScraperFileType.ResumeLayout(False)
        Me.gbScraperFileType.PerformLayout()
        Me.gbScraperDurationFormat.ResumeLayout(False)
        Me.gbScraperDurationFormat.PerformLayout()
        Me.gbScraperGlobalLocks.ResumeLayout(False)
        Me.gbScraperGlobalLocks.PerformLayout()
        Me.gbScraperMiscellaneous.ResumeLayout(False)
        Me.gbScraperMiscellaneous.PerformLayout()
        Me.pnlScraper.ResumeLayout(False)
        Me.gbHelp.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents btnApply As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents pnlTop As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents chkCleanFolderJPG As System.Windows.Forms.CheckBox
    Friend WithEvents chkCleanFanartJPG As System.Windows.Forms.CheckBox
    Friend WithEvents chkCleanMovieTBNb As System.Windows.Forms.CheckBox
    Friend WithEvents chkCleanMovieTBN As System.Windows.Forms.CheckBox
    Friend WithEvents chkCleanMovieNFOb As System.Windows.Forms.CheckBox
    Friend WithEvents chkCleanMovieNFO As System.Windows.Forms.CheckBox
    Friend WithEvents chkCleanMovieFanartJPG As System.Windows.Forms.CheckBox
    Friend WithEvents gbGeneralMiscellaneous As System.Windows.Forms.GroupBox
    Friend WithEvents chkLogErrors As System.Windows.Forms.CheckBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents chkOverwriteNfo As System.Windows.Forms.CheckBox
    Friend WithEvents lvMovies As System.Windows.Forms.ListView
    Friend WithEvents colPath As System.Windows.Forms.ColumnHeader
    Friend WithEvents colRecur As System.Windows.Forms.ColumnHeader
    Friend WithEvents chkOverwriteFanart As System.Windows.Forms.CheckBox
    Friend WithEvents chkOverwritePoster As System.Windows.Forms.CheckBox
    Friend WithEvents cbFanartSize As System.Windows.Forms.ComboBox
    Friend WithEvents lblFanartSize As System.Windows.Forms.Label
    Friend WithEvents lblPosterSize As System.Windows.Forms.Label
    Friend WithEvents cbPosterSize As System.Windows.Forms.ComboBox
    Friend WithEvents gbMoviesMediaList As System.Windows.Forms.GroupBox
    Friend WithEvents chkMovieTrailerCol As System.Windows.Forms.CheckBox
    Friend WithEvents chkMovieInfoCol As System.Windows.Forms.CheckBox
    Friend WithEvents chkMovieFanartCol As System.Windows.Forms.CheckBox
    Friend WithEvents chkMoviePosterCol As System.Windows.Forms.CheckBox
    Friend WithEvents btnMovieRem As System.Windows.Forms.Button
    Friend WithEvents btnMovieAddFolder As System.Windows.Forms.Button
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents gbSourcesFileNaming As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents chkFolderJPG As System.Windows.Forms.CheckBox
    Friend WithEvents chkPosterJPG As System.Windows.Forms.CheckBox
    Friend WithEvents chkPosterTBN As System.Windows.Forms.CheckBox
    Friend WithEvents chkMovieNameJPG As System.Windows.Forms.CheckBox
    Friend WithEvents chkMovieJPG As System.Windows.Forms.CheckBox
    Friend WithEvents chkMovieNameTBN As System.Windows.Forms.CheckBox
    Friend WithEvents chkMovieTBN As System.Windows.Forms.CheckBox
    Friend WithEvents chkMovieNameNFO As System.Windows.Forms.CheckBox
    Friend WithEvents chkMovieNFO As System.Windows.Forms.CheckBox
    Friend WithEvents chkMovieNameFanartJPG As System.Windows.Forms.CheckBox
    Friend WithEvents chkFanartJPG As System.Windows.Forms.CheckBox
    Friend WithEvents gbImagesImages As System.Windows.Forms.GroupBox
    Friend WithEvents chkMovieNameDotFanartJPG As System.Windows.Forms.CheckBox
    Friend WithEvents chkSingleScrapeImages As System.Windows.Forms.CheckBox
    Friend WithEvents chkCleanMovieNameJPG As System.Windows.Forms.CheckBox
    Friend WithEvents chkCleanMovieJPG As System.Windows.Forms.CheckBox
    Friend WithEvents chkCleanPosterJPG As System.Windows.Forms.CheckBox
    Friend WithEvents chkCleanPosterTBN As System.Windows.Forms.CheckBox
    Friend WithEvents chkCleanDotFanartJPG As System.Windows.Forms.CheckBox
    Friend WithEvents gbMoviesMiscellaneous As System.Windows.Forms.GroupBox
    Friend WithEvents chkMarkNew As System.Windows.Forms.CheckBox
    Friend WithEvents gbImagesFanart As System.Windows.Forms.GroupBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents chkResizeFanart As System.Windows.Forms.CheckBox
    Friend WithEvents txtFanartWidth As System.Windows.Forms.TextBox
    Friend WithEvents txtFanartHeight As System.Windows.Forms.TextBox
    Friend WithEvents gbImagesPoster As System.Windows.Forms.GroupBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents chkResizePoster As System.Windows.Forms.CheckBox
    Friend WithEvents txtPosterWidth As System.Windows.Forms.TextBox
    Friend WithEvents txtPosterHeight As System.Windows.Forms.TextBox
    Friend WithEvents chkAutoThumbs As System.Windows.Forms.CheckBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtAutoThumbs As System.Windows.Forms.TextBox
    Friend WithEvents ilSettings As System.Windows.Forms.ImageList
    Friend WithEvents tvSettings As System.Windows.Forms.TreeView
    Friend WithEvents pnlGeneral As System.Windows.Forms.Panel
    Friend WithEvents pnlXBMCCom As System.Windows.Forms.Panel
    Friend WithEvents pnlMovies As System.Windows.Forms.Panel
    Friend WithEvents lblCurrent As System.Windows.Forms.Label
    Friend WithEvents pnlCurrent As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents chkNoSpoilers As System.Windows.Forms.CheckBox
    Friend WithEvents chkCleanExtrathumbs As System.Windows.Forms.CheckBox
    Friend WithEvents pnlExtensions As System.Windows.Forms.Panel
    Friend WithEvents GroupBox18 As System.Windows.Forms.GroupBox
    Friend WithEvents btnRemMovieExt As System.Windows.Forms.Button
    Friend WithEvents btnAddMovieExt As System.Windows.Forms.Button
    Friend WithEvents txtMovieExt As System.Windows.Forms.TextBox
    Friend WithEvents lstMovieExts As System.Windows.Forms.ListBox
    Friend WithEvents chkUpdates As System.Windows.Forms.CheckBox
    Friend WithEvents gbSourcesBackdrops As System.Windows.Forms.GroupBox
    Friend WithEvents txtBDPath As System.Windows.Forms.TextBox
    Friend WithEvents btnBrowse As System.Windows.Forms.Button
    Friend WithEvents chkAutoBD As System.Windows.Forms.CheckBox
    Friend WithEvents chkMovieExtraCol As System.Windows.Forms.CheckBox
    Friend WithEvents chkMovieSubCol As System.Windows.Forms.CheckBox
    Friend WithEvents pnlSources As System.Windows.Forms.Panel
    Friend WithEvents lbGenre As System.Windows.Forms.CheckedListBox
    Friend WithEvents chkUseETasFA As System.Windows.Forms.CheckBox
    Friend WithEvents pnlImages As System.Windows.Forms.Panel
    Friend WithEvents gbImagesCaching As System.Windows.Forms.GroupBox
    Friend WithEvents chkPersistImgCache As System.Windows.Forms.CheckBox
    Friend WithEvents chkUseImgCache As System.Windows.Forms.CheckBox
    Friend WithEvents chkUseImgCacheUpdaters As System.Windows.Forms.CheckBox
    Friend WithEvents gbSourcesMiscellaneous As System.Windows.Forms.GroupBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents txtSkipLessThan As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents chkSkipStackedSizeCheck As System.Windows.Forms.CheckBox
    Friend WithEvents lblPosterQual As System.Windows.Forms.Label
    Friend WithEvents tbPosterQual As System.Windows.Forms.TrackBar
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents lblFanartQual As System.Windows.Forms.Label
    Friend WithEvents tbFanartQual As System.Windows.Forms.TrackBar
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents chkFanartOnly As System.Windows.Forms.CheckBox
    Friend WithEvents chkNoSaveImagesToNfo As System.Windows.Forms.CheckBox
    Friend WithEvents tcCleaner As System.Windows.Forms.TabControl
    Friend WithEvents tpStandard As System.Windows.Forms.TabPage
    Friend WithEvents tpExpert As System.Windows.Forms.TabPage
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents btnRemoveWhitelist As System.Windows.Forms.Button
    Friend WithEvents btnAddWhitelist As System.Windows.Forms.Button
    Friend WithEvents txtWhitelist As System.Windows.Forms.TextBox
    Friend WithEvents lstWhitelist As System.Windows.Forms.ListBox
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents chkWhitelistVideo As System.Windows.Forms.CheckBox
    Friend WithEvents chkInfoPanelAnim As System.Windows.Forms.CheckBox
    Friend WithEvents chkShowDims As System.Windows.Forms.CheckBox
    Friend WithEvents chkNoDisplayFanart As System.Windows.Forms.CheckBox
    Friend WithEvents chkNoDisplayPoster As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox21 As System.Windows.Forms.GroupBox
    Friend WithEvents rbBracketTrailer As System.Windows.Forms.RadioButton
    Friend WithEvents rbDashTrailer As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox22 As System.Windows.Forms.GroupBox
    Friend WithEvents btnRemoveNoStack As System.Windows.Forms.Button
    Friend WithEvents btnAddNoStack As System.Windows.Forms.Button
    Friend WithEvents txtNoStack As System.Windows.Forms.TextBox
    Friend WithEvents lstNoStack As System.Windows.Forms.ListBox
    Friend WithEvents colName As System.Windows.Forms.ColumnHeader
    Friend WithEvents colFolder As System.Windows.Forms.ColumnHeader
    Friend WithEvents colSingle As System.Windows.Forms.ColumnHeader
    Friend WithEvents colID As System.Windows.Forms.ColumnHeader
    Friend WithEvents fbdBrowse As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents btnEditSource As System.Windows.Forms.Button
    Friend WithEvents chkShowGenresText As System.Windows.Forms.CheckBox
    Friend WithEvents chkDisplayYear As System.Windows.Forms.CheckBox
    Friend WithEvents gbImagesExtrathumbs As System.Windows.Forms.GroupBox
    Friend WithEvents gbImagesSizing As System.Windows.Forms.GroupBox
    Friend WithEvents chkETPadding As System.Windows.Forms.CheckBox
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents txtETWidth As System.Windows.Forms.TextBox
    Friend WithEvents txtETHeight As System.Windows.Forms.TextBox
    Friend WithEvents rbETCustom As System.Windows.Forms.RadioButton
    Friend WithEvents rbETNative As System.Windows.Forms.RadioButton
    Friend WithEvents chkMovieNameMultiOnly As System.Windows.Forms.CheckBox
    Friend WithEvents gbMoviesSortToken As System.Windows.Forms.GroupBox
    Friend WithEvents btnRemoveToken As System.Windows.Forms.Button
    Friend WithEvents btnAddToken As System.Windows.Forms.Button
    Friend WithEvents txtSortToken As System.Windows.Forms.TextBox
    Friend WithEvents lstSortTokens As System.Windows.Forms.ListBox
    Friend WithEvents txtCheckTitleTol As System.Windows.Forms.TextBox
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents chkCheckTitles As System.Windows.Forms.CheckBox
    Friend WithEvents chkAutoDetectVTS As System.Windows.Forms.CheckBox
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents cbIntLang As System.Windows.Forms.ComboBox
    Friend WithEvents gbMoviesMissingFilter As System.Windows.Forms.GroupBox
    Friend WithEvents chkMissingExtra As System.Windows.Forms.CheckBox
    Friend WithEvents chkMissingSubs As System.Windows.Forms.CheckBox
    Friend WithEvents chkMissingTrailer As System.Windows.Forms.CheckBox
    Friend WithEvents chkMissingNFO As System.Windows.Forms.CheckBox
    Friend WithEvents chkMissingFanart As System.Windows.Forms.CheckBox
    Friend WithEvents chkMissingPoster As System.Windows.Forms.CheckBox
    Friend WithEvents cbAutoETSize As System.Windows.Forms.ComboBox
    Friend WithEvents chkAutoETSize As System.Windows.Forms.CheckBox
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents cbMovieTheme As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox29 As System.Windows.Forms.GroupBox
    Friend WithEvents ToolTips As System.Windows.Forms.ToolTip
    Friend WithEvents pnlTVSources As System.Windows.Forms.Panel
    Friend WithEvents btnEditTVSource As System.Windows.Forms.Button
    Friend WithEvents lvTVSources As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnRemTVSource As System.Windows.Forms.Button
    Friend WithEvents btnAddTVSource As System.Windows.Forms.Button
    Friend WithEvents chkCleanDB As System.Windows.Forms.CheckBox
    Friend WithEvents chkIgnoreLastScan As System.Windows.Forms.CheckBox
    Friend WithEvents pnlShows As System.Windows.Forms.Panel
    Friend WithEvents gbShowEpFilter As System.Windows.Forms.GroupBox
    Friend WithEvents btnEpFilterDown As System.Windows.Forms.Button
    Friend WithEvents btnEpFilterUp As System.Windows.Forms.Button
    Friend WithEvents chkEpProperCase As System.Windows.Forms.CheckBox
    Friend WithEvents btnRemoveEpFilter As System.Windows.Forms.Button
    Friend WithEvents btnAddEpFilter As System.Windows.Forms.Button
    Friend WithEvents txtEpFilter As System.Windows.Forms.TextBox
    Friend WithEvents lstEpFilters As System.Windows.Forms.ListBox
    Friend WithEvents gbShowFilter As System.Windows.Forms.GroupBox
    Friend WithEvents btnShowFilterDown As System.Windows.Forms.Button
    Friend WithEvents btnShowFilterUp As System.Windows.Forms.Button
    Friend WithEvents chkShowProperCase As System.Windows.Forms.CheckBox
    Friend WithEvents btnRemoveShowFilter As System.Windows.Forms.Button
    Friend WithEvents btnAddShowFilter As System.Windows.Forms.Button
    Friend WithEvents txtShowFilter As System.Windows.Forms.TextBox
    Friend WithEvents lstShowFilters As System.Windows.Forms.ListBox
    Friend WithEvents gbMoviesFilters As System.Windows.Forms.GroupBox
    Friend WithEvents btnDown As System.Windows.Forms.Button
    Friend WithEvents btnUp As System.Windows.Forms.Button
    Friend WithEvents chkProperCase As System.Windows.Forms.CheckBox
    Friend WithEvents btnRemoveFilter As System.Windows.Forms.Button
    Friend WithEvents btnAddFilter As System.Windows.Forms.Button
    Friend WithEvents txtFilter As System.Windows.Forms.TextBox
    Friend WithEvents lstFilters As System.Windows.Forms.ListBox
    Friend WithEvents gbMoviesGenreFilter As System.Windows.Forms.GroupBox
    Friend WithEvents gbMiscTVSourceOpts As System.Windows.Forms.GroupBox
    Friend WithEvents chkTVIgnoreLastScan As System.Windows.Forms.CheckBox
    Friend WithEvents chkTVCleanDB As System.Windows.Forms.CheckBox
    Friend WithEvents gbGeneralInterface As System.Windows.Forms.GroupBox
    Friend WithEvents cbEpTheme As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cbTVShowTheme As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TabControl2 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents lvShowRegex As System.Windows.Forms.ListView
    Friend WithEvents colSeason As System.Windows.Forms.ColumnHeader
    Friend WithEvents colSeasonApply As System.Windows.Forms.ColumnHeader
    Friend WithEvents colEpisode As System.Windows.Forms.ColumnHeader
    Friend WithEvents colEpApply As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnAddShowRegex As System.Windows.Forms.Button
    Friend WithEvents btnEditShowRegex As System.Windows.Forms.Button
    Friend WithEvents btnRemoveShowRegex As System.Windows.Forms.Button
    Friend WithEvents txtSeasonRegex As System.Windows.Forms.TextBox
    Friend WithEvents cboEpRetrieve As System.Windows.Forms.ComboBox
    Friend WithEvents txtEpRegex As System.Windows.Forms.TextBox
    Friend WithEvents cboSeasonRetrieve As System.Windows.Forms.ComboBox
    Friend WithEvents lblSeasonMatch As System.Windows.Forms.Label
    Friend WithEvents gbShowRegex As System.Windows.Forms.GroupBox
    Friend WithEvents lblEpisodeRetrieve As System.Windows.Forms.Label
    Friend WithEvents lblSeasonRetrieve As System.Windows.Forms.Label
    Friend WithEvents lblEpisodeMatch As System.Windows.Forms.Label
    Friend WithEvents colRegID As System.Windows.Forms.ColumnHeader
    Friend WithEvents pnlTVImages As System.Windows.Forms.Panel
    Friend WithEvents gbShowFanartOpts As System.Windows.Forms.GroupBox
    Friend WithEvents txtShowFanartWidth As System.Windows.Forms.TextBox
    Friend WithEvents txtShowFanartHeight As System.Windows.Forms.TextBox
    Friend WithEvents lblShowFanartQual As System.Windows.Forms.Label
    Friend WithEvents tbShowFanartQual As System.Windows.Forms.TrackBar
    Friend WithEvents lblShowFanartQ As System.Windows.Forms.Label
    Friend WithEvents lblShowFanartWidth As System.Windows.Forms.Label
    Friend WithEvents lblShowFanartHeight As System.Windows.Forms.Label
    Friend WithEvents chkResizeShowFanart As System.Windows.Forms.CheckBox
    Friend WithEvents cbShowFanartSize As System.Windows.Forms.ComboBox
    Friend WithEvents lblShowFanartSize As System.Windows.Forms.Label
    Friend WithEvents chkOverwriteShowFanart As System.Windows.Forms.CheckBox
    Friend WithEvents gbShowPosterOpts As System.Windows.Forms.GroupBox
    Friend WithEvents txtShowPosterWidth As System.Windows.Forms.TextBox
    Friend WithEvents txtShowPosterHeight As System.Windows.Forms.TextBox
    Friend WithEvents lblShowPosterQual As System.Windows.Forms.Label
    Friend WithEvents tbShowPosterQual As System.Windows.Forms.TrackBar
    Friend WithEvents lblShowPosterQ As System.Windows.Forms.Label
    Friend WithEvents lblShowPosterWidth As System.Windows.Forms.Label
    Friend WithEvents lblShowPosterHeight As System.Windows.Forms.Label
    Friend WithEvents chkResizeShowPoster As System.Windows.Forms.CheckBox
    Friend WithEvents lblShowPosterSize As System.Windows.Forms.Label
    Friend WithEvents cbShowPosterSize As System.Windows.Forms.ComboBox
    Friend WithEvents chkOverwriteShowPoster As System.Windows.Forms.CheckBox
    Friend WithEvents TabControl3 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage5 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage7 As System.Windows.Forms.TabPage
    Friend WithEvents pnlTVScraper As System.Windows.Forms.Panel
    Friend WithEvents cbRatingRegion As System.Windows.Forms.ComboBox
    Friend WithEvents gbShowsMiscellaneous As System.Windows.Forms.GroupBox
    Friend WithEvents lblRatingRegion As System.Windows.Forms.Label
    Friend WithEvents gbTVNaming As System.Windows.Forms.GroupBox
    Friend WithEvents gbShowFanart As System.Windows.Forms.GroupBox
    Friend WithEvents chkShowDotFanart As System.Windows.Forms.CheckBox
    Friend WithEvents chkShowDashFanart As System.Windows.Forms.CheckBox
    Friend WithEvents chkShowFanartJPG As System.Windows.Forms.CheckBox
    Friend WithEvents gbShowPosters As System.Windows.Forms.GroupBox
    Friend WithEvents chkShowPosterJPG As System.Windows.Forms.CheckBox
    Friend WithEvents chkShowPosterTBN As System.Windows.Forms.CheckBox
    Friend WithEvents chkShowFolderJPG As System.Windows.Forms.CheckBox
    Friend WithEvents chkSeasonAllTBN As System.Windows.Forms.CheckBox
    Friend WithEvents gbSeasonPosters As System.Windows.Forms.GroupBox
    Friend WithEvents chkSeasonPosterJPG As System.Windows.Forms.CheckBox
    Friend WithEvents chkSeasonPosterTBN As System.Windows.Forms.CheckBox
    Friend WithEvents chkSeasonXTBN As System.Windows.Forms.CheckBox
    Friend WithEvents chkSeasonXXTBN As System.Windows.Forms.CheckBox
    Friend WithEvents gbEpisodeFanart As System.Windows.Forms.GroupBox
    Friend WithEvents chkEpisodeDotFanart As System.Windows.Forms.CheckBox
    Friend WithEvents chkEpisodeDashFanart As System.Windows.Forms.CheckBox
    Friend WithEvents gbEpisodePosters As System.Windows.Forms.GroupBox
    Friend WithEvents chkEpisodeJPG As System.Windows.Forms.CheckBox
    Friend WithEvents chkEpisodeTBN As System.Windows.Forms.CheckBox
    Friend WithEvents gbSeasonFanart As System.Windows.Forms.GroupBox
    Friend WithEvents chkSeasonDotFanart As System.Windows.Forms.CheckBox
    Friend WithEvents chkSeasonDashFanart As System.Windows.Forms.CheckBox
    Friend WithEvents chkSeasonFanartJPG As System.Windows.Forms.CheckBox
    Friend WithEvents chkSeasonNameJPG As System.Windows.Forms.CheckBox
    Friend WithEvents chkSeasonNameTBN As System.Windows.Forms.CheckBox
    Friend WithEvents gbShowMediaList As System.Windows.Forms.GroupBox
    Friend WithEvents gbEpisodeListOptions As System.Windows.Forms.GroupBox
    Friend WithEvents chkEpisodeNfoCol As System.Windows.Forms.CheckBox
    Friend WithEvents chkEpisodeFanartCol As System.Windows.Forms.CheckBox
    Friend WithEvents chkEpisodePosterCol As System.Windows.Forms.CheckBox
    Friend WithEvents gbSeasonListOptions As System.Windows.Forms.GroupBox
    Friend WithEvents chkSeasonFanartCol As System.Windows.Forms.CheckBox
    Friend WithEvents chkSeasonPosterCol As System.Windows.Forms.CheckBox
    Friend WithEvents gbShowListOptions As System.Windows.Forms.GroupBox
    Friend WithEvents chkShowNfoCol As System.Windows.Forms.CheckBox
    Friend WithEvents chkShowFanartCol As System.Windows.Forms.CheckBox
    Friend WithEvents chkShowPosterCol As System.Windows.Forms.CheckBox
    Friend WithEvents gbEpPosterOpts As System.Windows.Forms.GroupBox
    Friend WithEvents txtEpPosterWidth As System.Windows.Forms.TextBox
    Friend WithEvents txtEpPosterHeight As System.Windows.Forms.TextBox
    Friend WithEvents lblEpPosterQual As System.Windows.Forms.Label
    Friend WithEvents tbEpPosterQual As System.Windows.Forms.TrackBar
    Friend WithEvents lblEpPosterQ As System.Windows.Forms.Label
    Friend WithEvents lblEpPosterWidth As System.Windows.Forms.Label
    Friend WithEvents lblEpPosterHeight As System.Windows.Forms.Label
    Friend WithEvents chkResizeEpPoster As System.Windows.Forms.CheckBox
    Friend WithEvents chkOverwriteEpPoster As System.Windows.Forms.CheckBox
    Friend WithEvents gbEpFanartOpts As System.Windows.Forms.GroupBox
    Friend WithEvents txtEpFanartWidth As System.Windows.Forms.TextBox
    Friend WithEvents txtEpFanartHeight As System.Windows.Forms.TextBox
    Friend WithEvents lblEpFanartQual As System.Windows.Forms.Label
    Friend WithEvents tbEpFanartQual As System.Windows.Forms.TrackBar
    Friend WithEvents lblEpFanartQ As System.Windows.Forms.Label
    Friend WithEvents lblEpFanartWidth As System.Windows.Forms.Label
    Friend WithEvents lblEpFanartHeight As System.Windows.Forms.Label
    Friend WithEvents chkResizeEpFanart As System.Windows.Forms.CheckBox
    Friend WithEvents cbEpFanartSize As System.Windows.Forms.ComboBox
    Friend WithEvents lblEpFanartSize As System.Windows.Forms.Label
    Friend WithEvents chkOverwriteEpFanart As System.Windows.Forms.CheckBox
    Friend WithEvents chkSeasonFolderJPG As System.Windows.Forms.CheckBox
    Friend WithEvents gbProxy As System.Windows.Forms.GroupBox
    Friend WithEvents gbCreds As System.Windows.Forms.GroupBox
    Friend WithEvents chkEnableCredentials As System.Windows.Forms.CheckBox
    Friend WithEvents lblProxyPort As System.Windows.Forms.Label
    Friend WithEvents lblProxyURI As System.Windows.Forms.Label
    Friend WithEvents txtProxyPort As System.Windows.Forms.TextBox
    Friend WithEvents txtProxyURI As System.Windows.Forms.TextBox
    Friend WithEvents chkEnableProxy As System.Windows.Forms.CheckBox
    Friend WithEvents txtProxyDomain As System.Windows.Forms.TextBox
    Friend WithEvents lblProxyDomain As System.Windows.Forms.Label
    Friend WithEvents txtProxyPassword As System.Windows.Forms.TextBox
    Friend WithEvents txtProxyUsername As System.Windows.Forms.TextBox
    Friend WithEvents lblProxyUN As System.Windows.Forms.Label
    Friend WithEvents lblProxyPW As System.Windows.Forms.Label
    Friend WithEvents chkSourceFromFolder As System.Windows.Forms.CheckBox
    Friend WithEvents chkSortBeforeScan As System.Windows.Forms.CheckBox
    Friend WithEvents gbTVScraperOptions As System.Windows.Forms.GroupBox
    Friend WithEvents gbTVScraperLanguage As System.Windows.Forms.GroupBox
    Friend WithEvents lblTVLanguagePreferred As System.Windows.Forms.Label
    Friend WithEvents btnTVLanguageFetch As System.Windows.Forms.Button
    Friend WithEvents cbTVLanguage As System.Windows.Forms.ComboBox
    Friend WithEvents txtTVDBMirror As System.Windows.Forms.TextBox
    Friend WithEvents lblTVDBMirror As System.Windows.Forms.Label
    Friend WithEvents gbScraperMetaData As System.Windows.Forms.GroupBox
    Friend WithEvents gbScraperFileType As System.Windows.Forms.GroupBox
    Friend WithEvents lstMetaData As System.Windows.Forms.ListBox
    Friend WithEvents txtDefFIExt As System.Windows.Forms.TextBox
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents btnRemoveMetaDataFT As System.Windows.Forms.Button
    Friend WithEvents btnEditMetaDataFT As System.Windows.Forms.Button
    Friend WithEvents btnNewMetaDataFT As System.Windows.Forms.Button
    Friend WithEvents chkIFOScan As System.Windows.Forms.CheckBox
    Friend WithEvents cbLanguages As System.Windows.Forms.ComboBox
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents gbScraperDurationFormat As System.Windows.Forms.GroupBox
    Friend WithEvents chkScanMediaInfo As System.Windows.Forms.CheckBox
    Friend WithEvents chkUseMIDuration As System.Windows.Forms.CheckBox
    Friend WithEvents gbScraperGlobalLocks As System.Windows.Forms.GroupBox
    Friend WithEvents chkLockOutline As System.Windows.Forms.CheckBox
    Friend WithEvents chkLockPlot As System.Windows.Forms.CheckBox
    Friend WithEvents chkLockTrailer As System.Windows.Forms.CheckBox
    Friend WithEvents chkLockGenre As System.Windows.Forms.CheckBox
    Friend WithEvents chkLockRealStudio As System.Windows.Forms.CheckBox
    Friend WithEvents chkLockRating As System.Windows.Forms.CheckBox
    Friend WithEvents chkLockTagline As System.Windows.Forms.CheckBox
    Friend WithEvents chkLockTitle As System.Windows.Forms.CheckBox
    Friend WithEvents gbScraperFields As System.Windows.Forms.GroupBox
    Friend WithEvents chkTop250 As System.Windows.Forms.CheckBox
    Friend WithEvents chkCountry As System.Windows.Forms.CheckBox
    Friend WithEvents txtGenreLimit As System.Windows.Forms.TextBox
    Friend WithEvents lblLimit2 As System.Windows.Forms.Label
    Friend WithEvents txtActorLimit As System.Windows.Forms.TextBox
    Friend WithEvents lblLimit As System.Windows.Forms.Label
    Friend WithEvents chkCrew As System.Windows.Forms.CheckBox
    Friend WithEvents chkMusicBy As System.Windows.Forms.CheckBox
    Friend WithEvents chkProducers As System.Windows.Forms.CheckBox
    Friend WithEvents chkWriters As System.Windows.Forms.CheckBox
    Friend WithEvents chkStudio As System.Windows.Forms.CheckBox
    Friend WithEvents chkRuntime As System.Windows.Forms.CheckBox
    Friend WithEvents chkPlot As System.Windows.Forms.CheckBox
    Friend WithEvents chkOutline As System.Windows.Forms.CheckBox
    Friend WithEvents chkGenre As System.Windows.Forms.CheckBox
    Friend WithEvents chkDirector As System.Windows.Forms.CheckBox
    Friend WithEvents chkTagline As System.Windows.Forms.CheckBox
    Friend WithEvents chkCast As System.Windows.Forms.CheckBox
    Friend WithEvents chkVotes As System.Windows.Forms.CheckBox
    Friend WithEvents chkTrailer As System.Windows.Forms.CheckBox
    Friend WithEvents chkRating As System.Windows.Forms.CheckBox
    Friend WithEvents chkRelease As System.Windows.Forms.CheckBox
    Friend WithEvents chkMPAA As System.Windows.Forms.CheckBox
    Friend WithEvents chkYear As System.Windows.Forms.CheckBox
    Friend WithEvents chkTitle As System.Windows.Forms.CheckBox
    Friend WithEvents gbScraperMiscellaneous As System.Windows.Forms.GroupBox
    Friend WithEvents cbForce As System.Windows.Forms.ComboBox
    Friend WithEvents chkForceTitle As System.Windows.Forms.CheckBox
    Friend WithEvents chkOutlineForPlot As System.Windows.Forms.CheckBox
    Friend WithEvents chkCastWithImg As System.Windows.Forms.CheckBox
    Friend WithEvents chkUseCertForMPAA As System.Windows.Forms.CheckBox
    Friend WithEvents chkFullCast As System.Windows.Forms.CheckBox
    Friend WithEvents chkFullCrew As System.Windows.Forms.CheckBox
    Friend WithEvents cbCert As System.Windows.Forms.ComboBox
    Friend WithEvents chkCert As System.Windows.Forms.CheckBox
    Friend WithEvents pnlScraper As System.Windows.Forms.Panel
    Friend WithEvents TabPage6 As System.Windows.Forms.TabPage
    Friend WithEvents gbSeaPosterOpts As System.Windows.Forms.GroupBox
    Friend WithEvents txtSeaPosterWidth As System.Windows.Forms.TextBox
    Friend WithEvents txtSeaPosterHeight As System.Windows.Forms.TextBox
    Friend WithEvents lblSeaPosterQual As System.Windows.Forms.Label
    Friend WithEvents tbSeaPosterQual As System.Windows.Forms.TrackBar
    Friend WithEvents lblSeaPosterQ As System.Windows.Forms.Label
    Friend WithEvents lblSeaPosterWidth As System.Windows.Forms.Label
    Friend WithEvents lblSeaPosterHeight As System.Windows.Forms.Label
    Friend WithEvents chkSeaResizePoster As System.Windows.Forms.CheckBox
    Friend WithEvents lblSeaPosterSize As System.Windows.Forms.Label
    Friend WithEvents cbSeaPosterSize As System.Windows.Forms.ComboBox
    Friend WithEvents chkSeaOverwritePoster As System.Windows.Forms.CheckBox
    Friend WithEvents gbSeaFanartOpts As System.Windows.Forms.GroupBox
    Friend WithEvents txtSeaFanartWidth As System.Windows.Forms.TextBox
    Friend WithEvents txtSeaFanartHeight As System.Windows.Forms.TextBox
    Friend WithEvents lblSeaFanartQual As System.Windows.Forms.Label
    Friend WithEvents tbSeaFanartQual As System.Windows.Forms.TrackBar
    Friend WithEvents lblSeaFanartQ As System.Windows.Forms.Label
    Friend WithEvents lblSeaFanartWidth As System.Windows.Forms.Label
    Friend WithEvents lblSeaFanartHeight As System.Windows.Forms.Label
    Friend WithEvents chkSeaResizeFanart As System.Windows.Forms.CheckBox
    Friend WithEvents cbSeaFanartSize As System.Windows.Forms.ComboBox
    Friend WithEvents lblSeaFanartSize As System.Windows.Forms.Label
    Friend WithEvents chkSeaOverwriteFanart As System.Windows.Forms.CheckBox
    Friend WithEvents lblAPIKey As System.Windows.Forms.Label
    Friend WithEvents txtAPIKey As System.Windows.Forms.TextBox
    Friend WithEvents chkTVScanOrderModify As System.Windows.Forms.CheckBox
    Friend WithEvents chkScanOrderModify As System.Windows.Forms.CheckBox
    Friend WithEvents lblTVUpdate As System.Windows.Forms.Label
    Friend WithEvents cboTVUpdate As System.Windows.Forms.ComboBox
    Friend WithEvents chkNoFilterEpisode As System.Windows.Forms.CheckBox
    Friend WithEvents TabPage8 As System.Windows.Forms.TabPage
    Friend WithEvents chkGetEnglishImages As System.Windows.Forms.CheckBox
    Friend WithEvents chkOnlyTVImagesLanguage As System.Windows.Forms.CheckBox
    Friend WithEvents gbAllSeasonPoster As System.Windows.Forms.GroupBox
    Friend WithEvents chkSeasonAllJPG As System.Windows.Forms.CheckBox
    Friend WithEvents chkDisplayMissingEpisodes As System.Windows.Forms.CheckBox
    Friend WithEvents gbTVScraperMetaData As System.Windows.Forms.GroupBox
    Friend WithEvents gbTVScraperFileType As System.Windows.Forms.GroupBox
    Friend WithEvents lstTVMetaData As System.Windows.Forms.ListBox
    Friend WithEvents txtTVDefFIExt As System.Windows.Forms.TextBox
    Friend WithEvents Label49 As System.Windows.Forms.Label
    Friend WithEvents btnRemoveTVMetaDataFT As System.Windows.Forms.Button
    Friend WithEvents btnEditTVMetaDataFT As System.Windows.Forms.Button
    Friend WithEvents btnNewTVMetaDataFT As System.Windows.Forms.Button
    Friend WithEvents cboTVMetaDataOverlay As System.Windows.Forms.ComboBox
    Friend WithEvents Label50 As System.Windows.Forms.Label
    Friend WithEvents chkTVScanMetaData As System.Windows.Forms.CheckBox
    Friend WithEvents gbTVScraperFields As System.Windows.Forms.GroupBox
    Friend WithEvents gbTVScraperGlobalLocks As System.Windows.Forms.GroupBox
    Friend WithEvents chkEpLockPlot As System.Windows.Forms.CheckBox
    Friend WithEvents chkShowLockStudio As System.Windows.Forms.CheckBox
    Friend WithEvents chkEpLockRating As System.Windows.Forms.CheckBox
    Friend WithEvents chkEpLockTitle As System.Windows.Forms.CheckBox
    Friend WithEvents gbTVScraperEpLocks As System.Windows.Forms.GroupBox
    Friend WithEvents gbTVScraperShowLocks As System.Windows.Forms.GroupBox
    Friend WithEvents chkShowLockPlot As System.Windows.Forms.CheckBox
    Friend WithEvents chkShowLockGenre As System.Windows.Forms.CheckBox
    Friend WithEvents chkShowLockRating As System.Windows.Forms.CheckBox
    Friend WithEvents chkShowLockTitle As System.Windows.Forms.CheckBox
    Friend WithEvents gbTVScraperShow As System.Windows.Forms.GroupBox
    Friend WithEvents chkScraperShowEGU As System.Windows.Forms.CheckBox
    Friend WithEvents chkScraperShowMPAA As System.Windows.Forms.CheckBox
    Friend WithEvents chkScraperShowPlot As System.Windows.Forms.CheckBox
    Friend WithEvents chkScraperShowGenre As System.Windows.Forms.CheckBox
    Friend WithEvents chkScraperShowTitle As System.Windows.Forms.CheckBox
    Friend WithEvents gbTVScraperEpisode As System.Windows.Forms.GroupBox
    Friend WithEvents chkScraperEpTitle As System.Windows.Forms.CheckBox
    Friend WithEvents chkScraperEpEpisode As System.Windows.Forms.CheckBox
    Friend WithEvents chkScraperEpSeason As System.Windows.Forms.CheckBox
    Friend WithEvents chkScraperShowRating As System.Windows.Forms.CheckBox
    Friend WithEvents chkScraperShowActors As System.Windows.Forms.CheckBox
    Friend WithEvents chkScraperShowStudio As System.Windows.Forms.CheckBox
    Friend WithEvents chkScraperShowPremiered As System.Windows.Forms.CheckBox
    Friend WithEvents chkScraperEpActors As System.Windows.Forms.CheckBox
    Friend WithEvents chkScraperEpCredits As System.Windows.Forms.CheckBox
    Friend WithEvents chkScraperEpDirector As System.Windows.Forms.CheckBox
    Friend WithEvents chkScraperEpPlot As System.Windows.Forms.CheckBox
    Friend WithEvents chkScraperEpRating As System.Windows.Forms.CheckBox
    Friend WithEvents chkScraperEpAired As System.Windows.Forms.CheckBox
    Friend WithEvents Label51 As System.Windows.Forms.Label
    Friend WithEvents txtRuntimeFormat As System.Windows.Forms.TextBox
    Friend WithEvents chkCertification As System.Windows.Forms.CheckBox
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents pnlMain As System.Windows.Forms.Panel
    Friend WithEvents pbCurrent As System.Windows.Forms.PictureBox
    Friend WithEvents gbImagesTrailers As System.Windows.Forms.GroupBox
    Friend WithEvents chkDeleteAllTrailers As System.Windows.Forms.CheckBox
    Friend WithEvents chkOverwriteTrailer As System.Windows.Forms.CheckBox
    Friend WithEvents chkNoDLTrailer As System.Windows.Forms.CheckBox
    Friend WithEvents chkSingleScrapeTrailer As System.Windows.Forms.CheckBox
    Friend WithEvents chkUpdaterTrailer As System.Windows.Forms.CheckBox
    Friend WithEvents chkDownloadTrailer As System.Windows.Forms.CheckBox
    Friend WithEvents cbTrailerQuality As System.Windows.Forms.ComboBox
    Friend WithEvents lblPreferredQuality As System.Windows.Forms.Label
    Friend WithEvents chkShowJPG As System.Windows.Forms.CheckBox
    Friend WithEvents chkShowTBN As System.Windows.Forms.CheckBox
    Friend WithEvents chkDisplayAllSeason As System.Windows.Forms.CheckBox
    Friend WithEvents gbHelp As System.Windows.Forms.GroupBox
    Friend WithEvents lblHelp As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents chkMarkNewShows As System.Windows.Forms.CheckBox
    Friend WithEvents chkMarkNewEpisodes As System.Windows.Forms.CheckBox
    Friend WithEvents chkOnlyValueForCert As System.Windows.Forms.CheckBox
    Friend WithEvents rbPoster As System.Windows.Forms.RadioButton
    Friend WithEvents rbBanner As System.Windows.Forms.RadioButton
    Friend WithEvents gbAllSPosterOpts As System.Windows.Forms.GroupBox
    Friend WithEvents rbAllSPoster As System.Windows.Forms.RadioButton
    Friend WithEvents rbAllSBanner As System.Windows.Forms.RadioButton
    Friend WithEvents txtAllSPosterWidth As System.Windows.Forms.TextBox
    Friend WithEvents txtAllSPosterHeight As System.Windows.Forms.TextBox
    Friend WithEvents lblAllSPosterQual As System.Windows.Forms.Label
    Friend WithEvents tbAllSPosterQual As System.Windows.Forms.TrackBar
    Friend WithEvents lblAllSPosterQ As System.Windows.Forms.Label
    Friend WithEvents lblAllSPosterWidth As System.Windows.Forms.Label
    Friend WithEvents lblAllSPosterHeight As System.Windows.Forms.Label
    Friend WithEvents chkResizeAllSPoster As System.Windows.Forms.CheckBox
    Friend WithEvents lblAllSPosterSize As System.Windows.Forms.Label
    Friend WithEvents cbAllSPosterSize As System.Windows.Forms.ComboBox
    Friend WithEvents chkOverwriteAllSPoster As System.Windows.Forms.CheckBox
    Friend WithEvents cbOrdering As System.Windows.Forms.ComboBox
    Friend WithEvents lblOrdering As System.Windows.Forms.Label
    Friend WithEvents btnResetShowFilters As System.Windows.Forms.Button
    Friend WithEvents btnResetEpFilter As System.Windows.Forms.Button
    Friend WithEvents btnResetMovieFilters As System.Windows.Forms.Button
    Friend WithEvents btnResetValidExts As System.Windows.Forms.Button
    Friend WithEvents btnResetShowRegex As System.Windows.Forms.Button
    Friend WithEvents btnRegexDown As System.Windows.Forms.Button
    Friend WithEvents btnRegexUp As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtTVSkipLessThan As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btnClearRegex As System.Windows.Forms.Button
    Friend WithEvents btnGetTVProfiles As System.Windows.Forms.Button
    Friend WithEvents chkAskCheckboxScrape As System.Windows.Forms.CheckBox
    Friend WithEvents chkClickScrape As System.Windows.Forms.CheckBox
    Friend WithEvents chkScraperActorThumbs As System.Windows.Forms.CheckBox
    Friend WithEvents chkPosterOnly As System.Windows.Forms.CheckBox
    Friend WithEvents gbShowBanner As System.Windows.Forms.GroupBox
    Friend WithEvents chkShowBannerJPG As System.Windows.Forms.CheckBox
    Friend WithEvents chkSeasonAllPosterJPG As System.Windows.Forms.CheckBox
    Friend WithEvents chkSeasonXXDashPosterJPG As System.Windows.Forms.CheckBox
    Friend WithEvents chkEpisodeDashThumbJPG As System.Windows.Forms.CheckBox
    Friend WithEvents chkSeasonXXDashFanartJPG As System.Windows.Forms.CheckBox
    Friend WithEvents chkMovieNameDashPosterJPG As System.Windows.Forms.CheckBox
    Friend WithEvents btnMovieFrodo As System.Windows.Forms.Button
    Friend WithEvents btnTVShowFrodo As System.Windows.Forms.Button
    Friend WithEvents chkVideoTSParentXBMC As System.Windows.Forms.CheckBox
    Friend WithEvents chkMovieNameNFOStack As System.Windows.Forms.CheckBox
    Friend WithEvents chkSpecialDateAdd As System.Windows.Forms.CheckBox
    Friend WithEvents chkLockLanguageV As System.Windows.Forms.CheckBox
    Friend WithEvents chkLockLanguageA As System.Windows.Forms.CheckBox
    Friend WithEvents chkLockMPAA As System.Windows.Forms.CheckBox
    Friend WithEvents chkUseMPAAFSK As System.Windows.Forms.CheckBox
    Friend WithEvents chkMovieWatchedCol As System.Windows.Forms.CheckBox
    Friend WithEvents chkLockSubtitle As System.Windows.Forms.CheckBox
    Friend WithEvents chkEpisodeWatchedCol As System.Windows.Forms.CheckBox
    Friend WithEvents chkPlotForOutline As System.Windows.Forms.CheckBox
    Friend WithEvents txtOutlineLimit As System.Windows.Forms.TextBox
    Friend WithEvents chkPosterGlassOverlay As System.Windows.Forms.CheckBox
    Friend WithEvents gbTVScraperDuration As System.Windows.Forms.GroupBox
    Friend WithEvents txtEPRuntimeFormat As System.Windows.Forms.TextBox
    Friend WithEvents chkUseEPDuration As System.Windows.Forms.CheckBox
    Friend WithEvents chkNoDisplayFanartSmall As System.Windows.Forms.CheckBox
End Class