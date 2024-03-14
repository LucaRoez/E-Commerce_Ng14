
export interface CatalogFormCard {
    responseMessage: string;
    formTitle: string;
    isSuccess: boolean;
    firstLabel: string;
    firstNgModel: number
    currencySymbol: string;
    secondLabel: string;
    secondNgModel: string;
    isThird: boolean;
    thirdLabel: string;
    thirdNgModel: string;
    buttonFunction?: (formCard: CatalogFormCard) => void;
    buttonLabel: string;
  }