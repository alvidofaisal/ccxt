// -------------------------------------------------------------------------------

// PLEASE DO NOT EDIT THIS FILE, IT IS GENERATED AND WILL BE OVERWRITTEN:
// https://github.com/ccxt/ccxt/blob/master/CONTRIBUTING.md#how-to-contribute-code

// -------------------------------------------------------------------------------

namespace ccxt;

public partial class upbit : Exchange
{
    public upbit (object args = null): base(args) {}

    public async Task<object> publicGetMarketAll (object parameters = null)
    {
        return await this.callAsync ("publicGetMarketAll",parameters);
    }

    public async Task<object> publicGetCandlesTimeframe (object parameters = null)
    {
        return await this.callAsync ("publicGetCandlesTimeframe",parameters);
    }

    public async Task<object> publicGetCandlesTimeframeUnit (object parameters = null)
    {
        return await this.callAsync ("publicGetCandlesTimeframeUnit",parameters);
    }

    public async Task<object> publicGetCandlesSeconds (object parameters = null)
    {
        return await this.callAsync ("publicGetCandlesSeconds",parameters);
    }

    public async Task<object> publicGetCandlesMinutesUnit (object parameters = null)
    {
        return await this.callAsync ("publicGetCandlesMinutesUnit",parameters);
    }

    public async Task<object> publicGetCandlesMinutes1 (object parameters = null)
    {
        return await this.callAsync ("publicGetCandlesMinutes1",parameters);
    }

    public async Task<object> publicGetCandlesMinutes3 (object parameters = null)
    {
        return await this.callAsync ("publicGetCandlesMinutes3",parameters);
    }

    public async Task<object> publicGetCandlesMinutes5 (object parameters = null)
    {
        return await this.callAsync ("publicGetCandlesMinutes5",parameters);
    }

    public async Task<object> publicGetCandlesMinutes10 (object parameters = null)
    {
        return await this.callAsync ("publicGetCandlesMinutes10",parameters);
    }

    public async Task<object> publicGetCandlesMinutes15 (object parameters = null)
    {
        return await this.callAsync ("publicGetCandlesMinutes15",parameters);
    }

    public async Task<object> publicGetCandlesMinutes30 (object parameters = null)
    {
        return await this.callAsync ("publicGetCandlesMinutes30",parameters);
    }

    public async Task<object> publicGetCandlesMinutes60 (object parameters = null)
    {
        return await this.callAsync ("publicGetCandlesMinutes60",parameters);
    }

    public async Task<object> publicGetCandlesMinutes240 (object parameters = null)
    {
        return await this.callAsync ("publicGetCandlesMinutes240",parameters);
    }

    public async Task<object> publicGetCandlesDays (object parameters = null)
    {
        return await this.callAsync ("publicGetCandlesDays",parameters);
    }

    public async Task<object> publicGetCandlesWeeks (object parameters = null)
    {
        return await this.callAsync ("publicGetCandlesWeeks",parameters);
    }

    public async Task<object> publicGetCandlesMonths (object parameters = null)
    {
        return await this.callAsync ("publicGetCandlesMonths",parameters);
    }

    public async Task<object> publicGetCandlesYears (object parameters = null)
    {
        return await this.callAsync ("publicGetCandlesYears",parameters);
    }

    public async Task<object> publicGetTradesTicks (object parameters = null)
    {
        return await this.callAsync ("publicGetTradesTicks",parameters);
    }

    public async Task<object> publicGetTicker (object parameters = null)
    {
        return await this.callAsync ("publicGetTicker",parameters);
    }

    public async Task<object> publicGetTickerAll (object parameters = null)
    {
        return await this.callAsync ("publicGetTickerAll",parameters);
    }

    public async Task<object> publicGetOrderbook (object parameters = null)
    {
        return await this.callAsync ("publicGetOrderbook",parameters);
    }

    public async Task<object> publicGetOrderbookSupportedLevels (object parameters = null)
    {
        return await this.callAsync ("publicGetOrderbookSupportedLevels",parameters);
    }

    public async Task<object> privateGetAccounts (object parameters = null)
    {
        return await this.callAsync ("privateGetAccounts",parameters);
    }

    public async Task<object> privateGetOrdersChance (object parameters = null)
    {
        return await this.callAsync ("privateGetOrdersChance",parameters);
    }

    public async Task<object> privateGetOrder (object parameters = null)
    {
        return await this.callAsync ("privateGetOrder",parameters);
    }

    public async Task<object> privateGetOrdersClosed (object parameters = null)
    {
        return await this.callAsync ("privateGetOrdersClosed",parameters);
    }

    public async Task<object> privateGetOrdersOpen (object parameters = null)
    {
        return await this.callAsync ("privateGetOrdersOpen",parameters);
    }

    public async Task<object> privateGetOrdersUuids (object parameters = null)
    {
        return await this.callAsync ("privateGetOrdersUuids",parameters);
    }

    public async Task<object> privateGetWithdraws (object parameters = null)
    {
        return await this.callAsync ("privateGetWithdraws",parameters);
    }

    public async Task<object> privateGetWithdraw (object parameters = null)
    {
        return await this.callAsync ("privateGetWithdraw",parameters);
    }

    public async Task<object> privateGetWithdrawsChance (object parameters = null)
    {
        return await this.callAsync ("privateGetWithdrawsChance",parameters);
    }

    public async Task<object> privateGetWithdrawsCoinAddresses (object parameters = null)
    {
        return await this.callAsync ("privateGetWithdrawsCoinAddresses",parameters);
    }

    public async Task<object> privateGetDeposits (object parameters = null)
    {
        return await this.callAsync ("privateGetDeposits",parameters);
    }

    public async Task<object> privateGetDepositsChanceCoin (object parameters = null)
    {
        return await this.callAsync ("privateGetDepositsChanceCoin",parameters);
    }

    public async Task<object> privateGetDeposit (object parameters = null)
    {
        return await this.callAsync ("privateGetDeposit",parameters);
    }

    public async Task<object> privateGetDepositsCoinAddresses (object parameters = null)
    {
        return await this.callAsync ("privateGetDepositsCoinAddresses",parameters);
    }

    public async Task<object> privateGetDepositsCoinAddress (object parameters = null)
    {
        return await this.callAsync ("privateGetDepositsCoinAddress",parameters);
    }

    public async Task<object> privateGetTravelRuleVasps (object parameters = null)
    {
        return await this.callAsync ("privateGetTravelRuleVasps",parameters);
    }

    public async Task<object> privateGetStatusWallet (object parameters = null)
    {
        return await this.callAsync ("privateGetStatusWallet",parameters);
    }

    public async Task<object> privateGetApiKeys (object parameters = null)
    {
        return await this.callAsync ("privateGetApiKeys",parameters);
    }

    public async Task<object> privatePostOrders (object parameters = null)
    {
        return await this.callAsync ("privatePostOrders",parameters);
    }

    public async Task<object> privatePostOrdersCancelAndNew (object parameters = null)
    {
        return await this.callAsync ("privatePostOrdersCancelAndNew",parameters);
    }

    public async Task<object> privatePostWithdrawsCoin (object parameters = null)
    {
        return await this.callAsync ("privatePostWithdrawsCoin",parameters);
    }

    public async Task<object> privatePostWithdrawsKrw (object parameters = null)
    {
        return await this.callAsync ("privatePostWithdrawsKrw",parameters);
    }

    public async Task<object> privatePostDepositsKrw (object parameters = null)
    {
        return await this.callAsync ("privatePostDepositsKrw",parameters);
    }

    public async Task<object> privatePostDepositsGenerateCoinAddress (object parameters = null)
    {
        return await this.callAsync ("privatePostDepositsGenerateCoinAddress",parameters);
    }

    public async Task<object> privatePostTravelRuleDepositUuid (object parameters = null)
    {
        return await this.callAsync ("privatePostTravelRuleDepositUuid",parameters);
    }

    public async Task<object> privatePostTravelRuleDepositTxid (object parameters = null)
    {
        return await this.callAsync ("privatePostTravelRuleDepositTxid",parameters);
    }

    public async Task<object> privateDeleteOrder (object parameters = null)
    {
        return await this.callAsync ("privateDeleteOrder",parameters);
    }

    public async Task<object> privateDeleteOrdersOpen (object parameters = null)
    {
        return await this.callAsync ("privateDeleteOrdersOpen",parameters);
    }

    public async Task<object> privateDeleteOrdersUuids (object parameters = null)
    {
        return await this.callAsync ("privateDeleteOrdersUuids",parameters);
    }

}