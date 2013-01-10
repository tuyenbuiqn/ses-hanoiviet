<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ucListTourType.ascx.cs" Inherits="SES.VTTEN.WEB.AdminCP.PageUC.ucListTourType" %>
<%@ Register Assembly="DevExpress.Web.ASPxTreeList.v9.2, Version=9.2.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxTreeList" TagPrefix="dxwtl" %>
<%@ Register Assembly="DevExpress.Web.ASPxEditors.v9.2, Version=9.2.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxEditors" TagPrefix="dxe" %>
    <h2>Danh mục tour</h2>
<div style="margin-left:60px; margin-top:20px; width:900px">
            <dxwtl:ASPxTreeList ID="tlTourType" runat="server" Width="100%" AutoGenerateColumns="False"
                CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css" 
                CssPostfix="PlasticBlue" KeyFieldName="TourTypeID"
                ParentFieldName="ParentID" ClientInstanceName="tlTourType" EnableCallbacks="False"
                EnableViewState="False" 
                OnStartNodeEditing="tlTourType_StartNodeEditing" 
                OnNodeDeleted="tlTourType_NodeDeleted">
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
                    <CustomizationWindowClose Height="14px" Width="14px" />
                </Images>
                <SettingsPager Mode="ShowPager" PageSize="25" ShowDefaultImages="False">
                    <AllButton Text="All">
                    </AllButton>
                    <NextPageButton Text="Next &gt;">
                    </NextPageButton>
                    <PrevPageButton Text="&lt; Prev">
                    </PrevPageButton>
                </SettingsPager>
                <SettingsBehavior AllowFocusedNode="True" />
                <Columns>
                    <dxwtl:TreeListTextColumn FieldName="TourTypeID" VisibleIndex="0" Visible="False">
                    </dxwtl:TreeListTextColumn>
                    <dxwtl:TreeListTextColumn FieldName="ParentID" Visible="False" VisibleIndex="1">
                    </dxwtl:TreeListTextColumn>
                    <dxwtl:TreeListTextColumn Caption="Tên Loại" FieldName="Title" VisibleIndex="2">
                    </dxwtl:TreeListTextColumn>
                    <dxwtl:TreeListTextColumn Caption="Mô tả" FieldName="Description" VisibleIndex="3">
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
                    <dxwtl:TreeListButtonEditColumn VisibleIndex= "8">
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