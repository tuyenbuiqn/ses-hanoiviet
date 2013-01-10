<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ucListDestination.ascx.cs"
    Inherits="SES.VTTEN.WEB.AdminCP.PageUC.ucListDestination" %>
<%@ Register Assembly="DevExpress.Web.ASPxTreeList.v9.2, Version=9.2.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxTreeList" TagPrefix="dxwtl" %>
<%@ Register Assembly="DevExpress.Web.ASPxEditors.v9.2, Version=9.2.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxEditors" TagPrefix="dxe" %>
    <h2>Danh sách điểm đến</h2>
<div style="margin-left:60px; margin-top:20px; width:900px">
            <dxwtl:ASPxTreeList ID="tlDestination" runat="server" Width="90%" AutoGenerateColumns="False"
                CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css" 
                CssPostfix="PlasticBlue" KeyFieldName="DestinationID"
                ParentFieldName="ParentID" ClientInstanceName="tlDestination" EnableCallbacks="False"
                EnableViewState="False" 
                OnStartNodeEditing="tlDestination_StartNodeEditing" 
                OnNodeDeleted="tlDestination_NodeDeleted">
                <Styles CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css" 
                    CssPostfix="PlasticBlue">
                    <CustomizationWindowContent VerticalAlign="Top">
                    </CustomizationWindowContent>
                </Styles>
                <Images ImageFolder="~/App_Themes/PlasticBlue/{0}/">
                    <CollapsedButton Height="9px" Url="~/App_Themes/PlasticBlue/TreeList/CollapsedButton.png"
                        Width="9px" />
                    <ExpandedButton Height="9px" Url="~/App_Themes/PlasticBlue/TreeList/ExpandedButton.png"
                        Width="9px" />
                    <SortAscending Height="11px" 
                        Url="~/App_Themes/PlasticBlue/TreeList/SortAsc.png" Width="11px" />
                    <SortDescending Height="11px" 
                        Url="~/App_Themes/PlasticBlue/TreeList/SortDesc.png" Width="11px" />
                    <CustomizationWindowClose Height="12px" Width="13px" />
                </Images>
                <SettingsPager Mode="ShowPager" pagesize="25" showdefaultimages="False">
                    <AllButton Text="All">
                    </AllButton>
                    <NextPageButton Text="Next &gt;">
                    </NextPageButton>
                    <PrevPageButton Text="&lt; Prev">
                    </PrevPageButton>
                </SettingsPager>
                <SettingsBehavior AllowFocusedNode="True" />
                <Columns>
                    <dxwtl:TreeListTextColumn FieldName="DestinationID" VisibleIndex="0" Visible="False">
                    </dxwtl:TreeListTextColumn>
                    <dxwtl:TreeListTextColumn FieldName="ParentID" Visible="False" VisibleIndex="1">
                    </dxwtl:TreeListTextColumn>
                    <dxwtl:TreeListTextColumn Caption="Tên địa danh" FieldName="Title" VisibleIndex="2">
                    </dxwtl:TreeListTextColumn>
                    <dxwtl:TreeListTextColumn Caption="Mô tả" FieldName="MetaDes" VisibleIndex="3">
                    </dxwtl:TreeListTextColumn>
                    <dxwtl:TreeListTextColumn Caption="MetaTag" FieldName="MetaTag" VisibleIndex="4">
                    </dxwtl:TreeListTextColumn>
                    <dxwtl:TreeListTextColumn Caption="OrderID" FieldName="OrderID" Visible="false" SortIndex="0"
                        SortOrder="Ascending" VisibleIndex="5">
                    </dxwtl:TreeListTextColumn>
                    <dxwtl:TreeListCommandColumn VisibleIndex="6" Caption="Edit">
                        <EditButton Visible="True">
                        </EditButton>
                    </dxwtl:TreeListCommandColumn>
                    <dxwtl:TreeListCommandColumn VisibleIndex="7" Caption="Delete">
                        <DeleteButton Visible="True">
                        </DeleteButton>
                    </dxwtl:TreeListCommandColumn>
                    <dxwtl:TreeListButtonEditColumn Visible="false" VisibleIndex= "8">
                        <DataCellTemplate>
                            <div style="float: left; vertical-align: middle;">
                                <dxe:ASPxButton ID="btup" Image-Url="../images/up_sort.gif" runat="server" AutoPostBack="False"
                                    EnableClientSideAPI="True" Height="16px" Width="5px" onclick="btup_Click">
                                    <Image Url="../images/up_sort.gif" />
                                </dxe:ASPxButton>
                            </div>
                            <dxe:ASPxButton ID="btdown" Image-Url="../images/down_sort.gif" runat="server" AutoPostBack="False"
                                EnableClientSideAPI="True" Height="16px" Width="5px" 
                                onclick="btdown_Click">
                                <Image Url="../images/down_sort.gif" />
                            </dxe:ASPxButton>
                        </DataCellTemplate>
                    </dxwtl:TreeListButtonEditColumn>
                </Columns>
            </dxwtl:ASPxTreeList>
  </div>      