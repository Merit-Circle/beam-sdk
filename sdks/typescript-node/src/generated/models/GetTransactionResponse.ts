/* generated using openapi-typescript-codegen -- do no edit */
/* istanbul ignore file */
/* tslint:disable */
/* eslint-disable */

export type GetTransactionResponse = {
  id: string;
  createdAt: number;
  updatedAt: number;
  chainId: number;
  userOperationHash?: string;
  userOperation?: any;
  response?: {
    createdAt: number;
    blockNumber?: number;
    transactionHash?: string;
    l1GasUsed?: string;
    gasUsed?: string;
    gasFee?: string;
    l1GasFee?: string;
    status?: number;
    logs?: Array<{
      blockNumber: number;
      blockHash: string;
      transactionIndex: number;
      removed: boolean;
      address: string;
      data: string;
      topics: string[];
      transactionHash: string;
      logIndex: number;
      orphaned?: boolean;
    }>;
    to?: string;
    error?: any;
  };
  interactions?: Array<{
    to?: string;
    value?: string;
    contract?: string;
    functionName?: string;
    functionArgs?: any[];
  }>;
};
