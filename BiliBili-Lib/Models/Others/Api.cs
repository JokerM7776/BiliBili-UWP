﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiliBili_Lib.Models.Others
{
    public class Api
    {
        /*
         * @pn: 页码，从1开始
         * @ps: 一页条目数量
         */
        public const string _apiBase = "https://api.bilibili.com";
        public const string _appBase = "https://app.bilibili.com";
        public const string _vcBase = "https://api.vc.bilibili.com";
        public const string _liveBase = "https://api.live.bilibili.com";
        public const string _passBase = "https://passport.bilibili.com";

        #region 验证
        /// <summary>
        /// 字符串加密
        /// </summary>
        public const string PASSPORT_KEY_ENCRYPT = _passBase + "/api/oauth2/getKey";
        /// <summary>
        /// 登录
        /// </summary>
        public const string PASSPORT_LOGIN = _passBase + "/api/v3/oauth2/login";
        /// <summary>
        /// 刷新令牌信息
        /// </summary>
        public const string PASSPORT_REFRESH_TOKEN = _passBase + "/api/oauth2/refreshToken";
        /// <summary>
        /// 验证令牌是否有效
        /// </summary>
        public const string PASSPORT_CHECK_TOKEN = _passBase + "/api/oauth2/info";
        /// <summary>
        /// SSO
        /// </summary>
        public const string PASSPORT_SSO = _passBase + "/api/login/sso";
        /// <summary>
        /// 获取验证码
        /// </summary>
        public const string PASSPORT_CAPTCHA = _passBase + "/captcha";
        #endregion

        #region 分区 Region
        /// <summary>
        /// 分区索引（包含子项）
        /// </summary>
        public const string REGION_INDEX = _appBase + "/x/v2/region/index";
        /// <summary>
        /// 分区初始加载
        /// </summary>
        public const string REGION_DYNAMIC_INIT = _appBase + "/x/v2/region/dynamic";
        /// <summary>
        /// 分区初始增量加载
        /// </summary>
        public const string REGION_DYNAMIC_REFRESH = _appBase + "/x/v2/region/dynamic/list";
        /// <summary>
        /// 分区子项初始加载
        /// </summary>
        public const string REGION_DYNAMIC_CHILD_INIT = _appBase + "/x/v2/region/dynamic/child";
        /// <summary>
        /// 分区子项初始增量加载
        /// </summary>
        public const string REGION_DYNAMIC_CHILD_REFRESH = _appBase + "/x/v2/region/dynamic/child/list";
        /// <summary>
        /// 分区子项按照一定规则排序后加载，分页
        /// </summary>
        public const string REGION_DYNAMIC_CHILD_SORT = _appBase + "/x/v2/region/show/child/list";
        /// <summary>
        /// 分区排行榜
        /// </summary>
        public const string REGION_RANK = _apiBase + "/x/web-interface/ranking/region";
        #endregion

        #region 账户 Account
        /// <summary>
        /// 我的信息
        /// </summary>
        public const string ACCOUNT_MINE = _appBase + "/x/v2/account/mine";
        /// <summary>
        /// 关注列表
        /// @分组索引使用vmid
        /// @分组详情用mid,pn,ps,tagid
        /// </summary>
        public const string ACCOUNT_FOLLOWING = _apiBase + "/x/relation/tags";
        /// <summary>
        /// 粉丝列表，使用vmid
        /// </summary>
        public const string ACCOUNT_FAN = _apiBase + "/x/relation/followers";
        /// <summary>
        /// 查询用户信息，使用vmid
        /// </summary>
        public const string ACCOUNT_INFO = _appBase + "/x/v2/space";
        /// <summary>
        /// 查询用户动态，使用vmid
        /// </summary>
        public const string ACCOUNT_USER_DYNAMIC = _vcBase + "/x/v2/space";
        /// <summary>
        /// 关注用户
        /// </summary>
        public const string ACCOUNT_FOLLOW_USER = _vcBase + "/feed/v1/feed/follow";
        /// <summary>
        /// 取消关注用户
        /// </summary>
        public const string ACCOUNT_UNFOLLOW_USER = _vcBase + "/feed/v1/feed/unfollow";
        /// <summary>
        /// 获取收藏夹列表
        /// </summary>
        public const string ACCOUNT_FAVORITE_LIST = _apiBase + "/medialist/gateway/base/created";
        /// <summary>
        /// 历史记录
        /// </summary>
        public const string ACCOUNT_HISTORY = _apiBase + "/x/v2/history";
        /// <summary>
        /// 清空历史记录
        /// </summary>
        public const string ACCOUNT_HISTORY_CLEAR = _apiBase + "/x/v2/history/clear";
        /// <summary>
        /// 我的播单信息
        /// </summary>
        public const string ACCOUNT_MEDIALIST = _apiBase + "/medialist/gateway/base/space";
        /// <summary>
        /// 稍后再看记录
        /// </summary>
        public const string ACCOUNT_VIEW_LATER = _apiBase + "/x/v2/history/toview";
        /// <summary>
        /// 收藏的专栏文章
        /// </summary>
        public const string ACCOUNT_FAVORITE_DOCUMENT = _apiBase + "/x/v2/favorite/article";
        /// <summary>
        /// 我的追番
        /// </summary>
        public const string ACCOUNT_FAVOROTE_ANIME = _apiBase + "/pgc/app/follow/v2/bangumi";
        /// <summary>
        /// 我的追剧
        /// </summary>
        public const string ACCOUNT_FAVOROTE_CINEMA = _apiBase + "/pgc/app/follow/v2/cinema";
        /// <summary>
        /// 收藏夹视频索引
        /// </summary>
        public const string ACCOUNT_FAVORITE_IDS = _apiBase + "/medialist/gateway/base/resource/ids";
        /// <summary>
        /// 收藏夹视频详情
        /// </summary>
        public const string ACCOUNT_FAVORITE_INFO = _apiBase + "/medialist/gateway/base/resource/infos";
        #endregion

        #region 频道 Channel
        /// <summary>
        /// 获取热门频道（通过offset进行刷新，一次+5）
        /// </summary>
        public const string CHANNEL_HOT = _appBase + "/x/v2/channel/recommend2";
        /// <summary>
        /// 获取频道页综合信息（包括订阅，热门频道，浏览的信息等）
        /// </summary>
        public const string CHANNEL_SQUARE = _appBase + "/x/v2/channel/square2";
        /// <summary>
        /// 获取频道的详细说明
        /// </summary>
        public const string CHANNEL_DETAIL = _appBase + "/x/v2/channel/detail";
        /// <summary>
        /// 获取频道下的视频列表
        /// </summary>
        public const string CHANNEL_VIDEO = _appBase + "/x/v2/channel/multiple";
        /// <summary>
        /// 取消频道订阅
        /// </summary>
        public const string CHANNEL_UNSUBSCRIBE = _appBase + "/x/channel/cancel";
        /// <summary>
        /// 添加频道订阅
        /// </summary>
        public const string CHANNEL_SUBSCRIBE = _appBase + "/x/channel/add";
        /// <summary>
        /// 获取频道列表分类
        /// </summary>
        public const string CHANNEL_TABS = _appBase + "/x/v2/channel/tab3";
        /// <summary>
        /// 获取某分类下频道列表
        /// </summary>
        public const string CHANNEL_LIST = _appBase + "/x/v2/channel/list";
        /// <summary>
        /// 获取我订阅的频道（包括标签）
        /// </summary>
        public const string CHANNEL_MYSUBSCRIBE = _appBase + "/x/v2/channel/mine";
        /// <summary>
        /// 搜索频道
        /// </summary>
        public const string CHANNEL_SEARCH = _appBase + "/x/v2/search/channel2";
        /// <summary>
        /// 标签基础信息
        /// </summary>
        public const string CHANNEL_TAG_TAB = _appBase + "/x/channel/feed/tab";
        /// <summary>
        /// 标签推荐视频
        /// </summary>
        public const string CHANNEL_TAG_RECOMMEND = _appBase + "/x/channel/feed/index";
        #endregion

        #region 应用 Application
        /// <summary>
        /// 热搜及其它搜索条目
        /// </summary>
        public const string APP_SEARCH_HOT = _appBase + "/x/v2/search/square";
        /// <summary>
        /// 综合搜索
        /// </summary>
        public const string APP_SEARCH_COMPLEX = _appBase + "/x/v2/search";
        /// <summary>
        /// 特殊类目搜索
        /// </summary>
        public const string APP_SEARCH_TYPE = _appBase + "/x/v2/search/type";
        /// <summary>
        /// 获取搜索建议
        /// </summary>
        public const string APP_SEARCH_SUGGEST = "http://s.search.bilibili.com/main/suggest";
        /// <summary>
        /// 获取全部emoji表情
        /// </summary>
        public const string APP_EMOJI = _apiBase + "/x/v2/reply/v2/emojis";
        #endregion

        #region 视频 Video
        /// <summary>
        /// 推荐视频
        /// </summary>
        public const string VIDEO_RECOMMEND = _appBase + "/x/v2/feed/index";
        /// <summary>
        /// 视频分P列表
        /// </summary>
        public const string VIDEO_PART = _apiBase + "/x/player/pagelist";
        /// <summary>
        /// 视频详细信息
        /// </summary>
        public const string VIDEO_DETAIL_INFO = _appBase + "/x/v2/view";
        /// <summary>
        /// 视频简易信息
        /// </summary>
        public const string VIDEO_SLIM_INFO = _apiBase + "/x/web-interface/archive/stat";
        /// <summary>
        /// 关联视频
        /// </summary>
        public const string VIDEO_RELATED = _apiBase + "/x/web-interface/archive/related";
        /// <summary>
        /// 获取播放地址
        /// </summary>
        public const string VIDEO_PLAY = _apiBase + "/x/player/playurl";
        /// <summary>
        /// 是否已点赞（视频）
        /// </summary>
        public const string VIDEO_IS_LIKE = _apiBase + "/x/web-interface/archive/has/like";
        /// <summary>
        /// 是否已投币（视频）
        /// </summary>
        public const string VIDEO_IS_COIN = _apiBase + "/x/web-interface/archive/coins";
        /// <summary>
        /// 是否已收藏（视频）
        /// </summary>
        public const string VIDEO_IS_FAVORITE = _apiBase + "/x/v2/fav/video/favoured";
        /// <summary>
        /// 点赞视频
        /// </summary>
        public const string VIDEO_LIKE = _appBase + "/x/v2/view/like";
        /// <summary>
        /// 投币
        /// </summary>
        public const string VIDEO_COIN = _appBase + "/x/v2/view/coin/add";
        /// <summary>
        /// 添加收藏夹
        /// </summary>
        public const string VIDEO_FAVORITE = _apiBase + "/medialist/gateway/coll/resource/deal";
        /// <summary>
        /// 一键三连
        /// </summary>
        public const string VIDEO_TRIPLE = _appBase + "/x/v2/view/like/triple";
        /// <summary>
        /// 添加观看记录
        /// </summary>
        public const string VIDEO_ADD_WATCH = _apiBase + "/x/v2/history/report";
        /// <summary>
        /// 获取互动视频选项
        /// </summary>
        public const string VIDEO_INTERACTION_EDGE = _apiBase + "/x/stein/edgeinfo_v2";
        #endregion

        #region 话题及动态 Topic Dynamic
        /// <summary>
        /// 获取动态
        /// </summary>
        public const string TOPIC_COMPLEX = _vcBase + "/topic_svr/v1/topic_svr/fetch_dynamics";
        /// <summary>
        /// 点赞动态
        /// </summary>
        public const string DYNAMIC_LIKE = _vcBase + "/dynamic_like/v1/dynamic_like/thumb";
        /// <summary>
        /// 获取新动态
        /// </summary>
        public const string DYNAMIC_NEW = _vcBase + "/dynamic_svr/v1/dynamic_svr/dynamic_new";
        /// <summary>
        /// 获取历史动态
        /// </summary>
        public const string DYNAMIC_HISTORY = _vcBase + "/dynamic_svr/v1/dynamic_svr/dynamic_history";
        #endregion

        #region 动漫 Anime
        /// <summary>
        /// 番剧综合信息
        /// </summary>
        public const string ANIME_JP_SQUARE = _apiBase + "/pgc/app/v2/page/bangumi/jp";
        /// <summary>
        /// 刷新动漫区块信息
        /// </summary>
        public const string ANIME_EXCHANGE = _apiBase + "/pgc/app/v2/page/exchange";
        /// <summary>
        /// 国创综合信息
        /// </summary>
        public const string ANIME_CHN_SQUARE = _apiBase + "/pgc/app/v2/page/bangumi/chn";
        #endregion

        #region 回复 Reply
        /// <summary>
        /// 获取回复列表
        /// </summary>
        public const string REPLY_LIST = _apiBase + "/x/v2/reply/main";
        /// <summary>
        /// 获取某回复详情
        /// </summary>
        public const string REPLY_DETAIL = _apiBase + "/x/v2/reply/detail";
        /// <summary>
        /// 点赞评论
        /// </summary>
        public const string REPLY_LIKE = _apiBase + "/x/v2/reply/action";
        #endregion
    }
}
