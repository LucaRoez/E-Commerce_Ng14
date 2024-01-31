/* tslint:disable */
/* eslint-disable */
import { HttpClient, HttpContext, HttpEvent, HttpEventType, HttpResponse } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { filter, map } from 'rxjs/operators';

import { BaseService } from '../base-service';
import { ApiConfiguration } from '../api-configuration';
import { StrictHttpResponse } from '../strict-http-response';
import { RequestBuilder } from '../request-builder';
import { Category, Currency, Gender } from '../models';


@Injectable({ providedIn: 'root' })
export class MainService extends BaseService {
  constructor(config: ApiConfiguration, http: HttpClient) {
    super(config, http);
  }

  /** Path part for operation `productsPost()` */
  static readonly ProductsPostPath = '/products';

  /**
   * This method provides access to the full `HttpResponse`, allowing access to response headers.
   * To access only the response body, use `productsPost()` instead.
   *
   * This method doesn't expect any request body.
   */
  productsPost$Response(
    params?: {
      init?: number;
      length?: number;
    },
    context?: HttpContext
  ): Observable<StrictHttpResponse<void>> {
    const rb = new RequestBuilder(this.rootUrl, MainService.ProductsPostPath, 'post');
    if (params) {
      rb.query('init', params.init, {});
      rb.query('length', params.length, {});
    }

    return this.http.request(
      rb.build({ responseType: 'text', accept: '*/*', context })
    ).pipe(
      filter((r: any): r is HttpResponse<any> => r instanceof HttpResponse),
      map((r: HttpResponse<any>) => {
        return (r as HttpResponse<any>).clone({ body: undefined }) as StrictHttpResponse<void>;
      })
    );
  }

  /**
   * This method provides access only to the response body.
   * To access the full response (for headers, for example), `productsPost$Response()` instead.
   *
   * This method doesn't expect any request body.
   */
  productsPost(
    params?: {
      init?: number;
      length?: number;
    },
    context?: HttpContext
  ): Observable<void> {
    return this.productsPost$Response(params, context).pipe(
      map((r: StrictHttpResponse<void>): void => r.body)
    );
  }

  /** Path part for operation `productsMalePost()` */
  static readonly ProductsMalePostPath = '/products/male';

  /**
   * This method provides access to the full `HttpResponse`, allowing access to response headers.
   * To access only the response body, use `productsMalePost()` instead.
   *
   * This method doesn't expect any request body.
   */
  productsMalePost$Response(
    params?: {
      init?: number;
      length?: number;
    },
    context?: HttpContext
  ): Observable<StrictHttpResponse<void>> {
    const rb = new RequestBuilder(this.rootUrl, MainService.ProductsMalePostPath, 'post');
    if (params) {
      rb.query('init', params.init, {});
      rb.query('length', params.length, {});
    }

    return this.http.request(
      rb.build({ responseType: 'text', accept: '*/*', context })
    ).pipe(
      filter((r: any): r is HttpResponse<any> => r instanceof HttpResponse),
      map((r: HttpResponse<any>) => {
        return (r as HttpResponse<any>).clone({ body: undefined }) as StrictHttpResponse<void>;
      })
    );
  }

  /**
   * This method provides access only to the response body.
   * To access the full response (for headers, for example), `productsMalePost$Response()` instead.
   *
   * This method doesn't expect any request body.
   */
  productsMalePost(
    params?: {
      init?: number;
      length?: number;
    },
    context?: HttpContext
  ): Observable<void> {
    return this.productsMalePost$Response(params, context).pipe(
      map((r: StrictHttpResponse<void>): void => r.body)
    );
  }

  /** Path part for operation `productsFemalePost()` */
  static readonly ProductsFemalePostPath = '/products/female';

  /**
   * This method provides access to the full `HttpResponse`, allowing access to response headers.
   * To access only the response body, use `productsFemalePost()` instead.
   *
   * This method doesn't expect any request body.
   */
  productsFemalePost$Response(
    params?: {
      init?: number;
      length?: number;
    },
    context?: HttpContext
  ): Observable<StrictHttpResponse<void>> {
    const rb = new RequestBuilder(this.rootUrl, MainService.ProductsFemalePostPath, 'post');
    if (params) {
      rb.query('init', params.init, {});
      rb.query('length', params.length, {});
    }

    return this.http.request(
      rb.build({ responseType: 'text', accept: '*/*', context })
    ).pipe(
      filter((r: any): r is HttpResponse<any> => r instanceof HttpResponse),
      map((r: HttpResponse<any>) => {
        return (r as HttpResponse<any>).clone({ body: undefined }) as StrictHttpResponse<void>;
      })
    );
  }

  /**
   * This method provides access only to the response body.
   * To access the full response (for headers, for example), `productsFemalePost$Response()` instead.
   *
   * This method doesn't expect any request body.
   */
  productsFemalePost(
    params?: {
      init?: number;
      length?: number;
    },
    context?: HttpContext
  ): Observable<void> {
    return this.productsFemalePost$Response(params, context).pipe(
      map((r: StrictHttpResponse<void>): void => r.body)
    );
  }

  /** Path part for operation `productsBabyfashionPost()` */
  static readonly ProductsBabyfashionPostPath = '/products/babyfashion';

  /**
   * This method provides access to the full `HttpResponse`, allowing access to response headers.
   * To access only the response body, use `productsBabyfashionPost()` instead.
   *
   * This method doesn't expect any request body.
   */
  productsBabyfashionPost$Response(
    params?: {
      init?: number;
      length?: number;
    },
    context?: HttpContext
  ): Observable<StrictHttpResponse<void>> {
    const rb = new RequestBuilder(this.rootUrl, MainService.ProductsBabyfashionPostPath, 'post');
    if (params) {
      rb.query('init', params.init, {});
      rb.query('length', params.length, {});
    }

    return this.http.request(
      rb.build({ responseType: 'text', accept: '*/*', context })
    ).pipe(
      filter((r: any): r is HttpResponse<any> => r instanceof HttpResponse),
      map((r: HttpResponse<any>) => {
        return (r as HttpResponse<any>).clone({ body: undefined }) as StrictHttpResponse<void>;
      })
    );
  }

  /**
   * This method provides access only to the response body.
   * To access the full response (for headers, for example), `productsBabyfashionPost$Response()` instead.
   *
   * This method doesn't expect any request body.
   */
  productsBabyfashionPost(
    params?: {
      init?: number;
      length?: number;
    },
    context?: HttpContext
  ): Observable<void> {
    return this.productsBabyfashionPost$Response(params, context).pipe(
      map((r: StrictHttpResponse<void>): void => r.body)
    );
  }

  /** Path part for operation `productsSummerPost()` */
  static readonly ProductsSummerPostPath = '/products/summer';

  /**
   * This method provides access to the full `HttpResponse`, allowing access to response headers.
   * To access only the response body, use `productsSummerPost()` instead.
   *
   * This method doesn't expect any request body.
   */
  productsSummerPost$Response(
    params?: {
      init?: number;
      length?: number;
    },
    context?: HttpContext
  ): Observable<StrictHttpResponse<void>> {
    const rb = new RequestBuilder(this.rootUrl, MainService.ProductsSummerPostPath, 'post');
    if (params) {
      rb.query('init', params.init, {});
      rb.query('length', params.length, {});
    }

    return this.http.request(
      rb.build({ responseType: 'text', accept: '*/*', context })
    ).pipe(
      filter((r: any): r is HttpResponse<any> => r instanceof HttpResponse),
      map((r: HttpResponse<any>) => {
        return (r as HttpResponse<any>).clone({ body: undefined }) as StrictHttpResponse<void>;
      })
    );
  }

  /**
   * This method provides access only to the response body.
   * To access the full response (for headers, for example), `productsSummerPost$Response()` instead.
   *
   * This method doesn't expect any request body.
   */
  productsSummerPost(
    params?: {
      init?: number;
      length?: number;
    },
    context?: HttpContext
  ): Observable<void> {
    return this.productsSummerPost$Response(params, context).pipe(
      map((r: StrictHttpResponse<void>): void => r.body)
    );
  }

  /** Path part for operation `productsWinterPost()` */
  static readonly ProductsWinterPostPath = '/products/winter';

  /**
   * This method provides access to the full `HttpResponse`, allowing access to response headers.
   * To access only the response body, use `productsWinterPost()` instead.
   *
   * This method doesn't expect any request body.
   */
  productsWinterPost$Response(
    params?: {
      init?: number;
      length?: number;
    },
    context?: HttpContext
  ): Observable<StrictHttpResponse<void>> {
    const rb = new RequestBuilder(this.rootUrl, MainService.ProductsWinterPostPath, 'post');
    if (params) {
      rb.query('init', params.init, {});
      rb.query('length', params.length, {});
    }

    return this.http.request(
      rb.build({ responseType: 'text', accept: '*/*', context })
    ).pipe(
      filter((r: any): r is HttpResponse<any> => r instanceof HttpResponse),
      map((r: HttpResponse<any>) => {
        return (r as HttpResponse<any>).clone({ body: undefined }) as StrictHttpResponse<void>;
      })
    );
  }

  /**
   * This method provides access only to the response body.
   * To access the full response (for headers, for example), `productsWinterPost$Response()` instead.
   *
   * This method doesn't expect any request body.
   */
  productsWinterPost(
    params?: {
      init?: number;
      length?: number;
    },
    context?: HttpContext
  ): Observable<void> {
    return this.productsWinterPost$Response(params, context).pipe(
      map((r: StrictHttpResponse<void>): void => r.body)
    );
  }

  /** Path part for operation `productsCasualPost()` */
  static readonly ProductsCasualPostPath = '/products/casual';

  /**
   * This method provides access to the full `HttpResponse`, allowing access to response headers.
   * To access only the response body, use `productsCasualPost()` instead.
   *
   * This method doesn't expect any request body.
   */
  productsCasualPost$Response(
    params?: {
      init?: number;
      length?: number;
    },
    context?: HttpContext
  ): Observable<StrictHttpResponse<void>> {
    const rb = new RequestBuilder(this.rootUrl, MainService.ProductsCasualPostPath, 'post');
    if (params) {
      rb.query('init', params.init, {});
      rb.query('length', params.length, {});
    }

    return this.http.request(
      rb.build({ responseType: 'text', accept: '*/*', context })
    ).pipe(
      filter((r: any): r is HttpResponse<any> => r instanceof HttpResponse),
      map((r: HttpResponse<any>) => {
        return (r as HttpResponse<any>).clone({ body: undefined }) as StrictHttpResponse<void>;
      })
    );
  }

  /**
   * This method provides access only to the response body.
   * To access the full response (for headers, for example), `productsCasualPost$Response()` instead.
   *
   * This method doesn't expect any request body.
   */
  productsCasualPost(
    params?: {
      init?: number;
      length?: number;
    },
    context?: HttpContext
  ): Observable<void> {
    return this.productsCasualPost$Response(params, context).pipe(
      map((r: StrictHttpResponse<void>): void => r.body)
    );
  }

  /** Path part for operation `productsFormalPost()` */
  static readonly ProductsFormalPostPath = '/products/formal';

  /**
   * This method provides access to the full `HttpResponse`, allowing access to response headers.
   * To access only the response body, use `productsFormalPost()` instead.
   *
   * This method doesn't expect any request body.
   */
  productsFormalPost$Response(
    params?: {
      init?: number;
      length?: number;
    },
    context?: HttpContext
  ): Observable<StrictHttpResponse<void>> {
    const rb = new RequestBuilder(this.rootUrl, MainService.ProductsFormalPostPath, 'post');
    if (params) {
      rb.query('init', params.init, {});
      rb.query('length', params.length, {});
    }

    return this.http.request(
      rb.build({ responseType: 'text', accept: '*/*', context })
    ).pipe(
      filter((r: any): r is HttpResponse<any> => r instanceof HttpResponse),
      map((r: HttpResponse<any>) => {
        return (r as HttpResponse<any>).clone({ body: undefined }) as StrictHttpResponse<void>;
      })
    );
  }

  /**
   * This method provides access only to the response body.
   * To access the full response (for headers, for example), `productsFormalPost$Response()` instead.
   *
   * This method doesn't expect any request body.
   */
  productsFormalPost(
    params?: {
      init?: number;
      length?: number;
    },
    context?: HttpContext
  ): Observable<void> {
    return this.productsFormalPost$Response(params, context).pipe(
      map((r: StrictHttpResponse<void>): void => r.body)
    );
  }

  /** Path part for operation `productsFashionPost()` */
  static readonly ProductsFashionPostPath = '/products/fashion';

  /**
   * This method provides access to the full `HttpResponse`, allowing access to response headers.
   * To access only the response body, use `productsFashionPost()` instead.
   *
   * This method doesn't expect any request body.
   */
  productsFashionPost$Response(
    params?: {
      init?: number;
      length?: number;
    },
    context?: HttpContext
  ): Observable<StrictHttpResponse<void>> {
    const rb = new RequestBuilder(this.rootUrl, MainService.ProductsFashionPostPath, 'post');
    if (params) {
      rb.query('init', params.init, {});
      rb.query('length', params.length, {});
    }

    return this.http.request(
      rb.build({ responseType: 'text', accept: '*/*', context })
    ).pipe(
      filter((r: any): r is HttpResponse<any> => r instanceof HttpResponse),
      map((r: HttpResponse<any>) => {
        return (r as HttpResponse<any>).clone({ body: undefined }) as StrictHttpResponse<void>;
      })
    );
  }

  /**
   * This method provides access only to the response body.
   * To access the full response (for headers, for example), `productsFashionPost$Response()` instead.
   *
   * This method doesn't expect any request body.
   */
  productsFashionPost(
    params?: {
      init?: number;
      length?: number;
    },
    context?: HttpContext
  ): Observable<void> {
    return this.productsFashionPost$Response(params, context).pipe(
      map((r: StrictHttpResponse<void>): void => r.body)
    );
  }

  /** Path part for operation `productsSearchPost()` */
  static readonly ProductsSearchPostPath = '/products/search';

  /**
   * This method provides access to the full `HttpResponse`, allowing access to response headers.
   * To access only the response body, use `productsSearchPost()` instead.
   *
   * This method doesn't expect any request body.
   */
  productsSearchPost$Response(
    params?: {
      genderFilter?: string;
      categoryFilter?: string;
    },
    context?: HttpContext
  ): Observable<StrictHttpResponse<void>> {
    const rb = new RequestBuilder(this.rootUrl, MainService.ProductsSearchPostPath, 'post');
    if (params) {
      rb.query('genderFilter', params.genderFilter, {});
      rb.query('categoryFilter', params.categoryFilter, {});
    }

    return this.http.request(
      rb.build({ responseType: 'text', accept: '*/*', context })
    ).pipe(
      filter((r: any): r is HttpResponse<any> => r instanceof HttpResponse),
      map((r: HttpResponse<any>) => {
        return (r as HttpResponse<any>).clone({ body: undefined }) as StrictHttpResponse<void>;
      })
    );
  }

  /**
   * This method provides access only to the response body.
   * To access the full response (for headers, for example), `productsSearchPost$Response()` instead.
   *
   * This method doesn't expect any request body.
   */
  productsSearchPost(
    params?: {
      genderFilter?: string;
      categoryFilter?: string;
    },
    context?: HttpContext
  ): Observable<void> {
    return this.productsSearchPost$Response(params, context).pipe(
      map((r: StrictHttpResponse<void>): void => r.body)
    );
  }

  /** Path part for operation `gendersPost()` */
  static readonly GendersPostPath = '/genders';

  /**
   * This method provides access to the full `HttpResponse`, allowing access to response headers.
   * To access only the response body, use `gendersPost()` instead.
   *
   * This method doesn't expect any request body.
   */
  gendersPost$Response(
    params?: {},
    context?: HttpContext
  ): Observable<StrictHttpResponse<Gender[]>> {
    const rb = new RequestBuilder(this.rootUrl, MainService.GendersPostPath, 'post');
    if (params) {
    }

    return this.http.request<Gender[]>(
      rb.build({ responseType: 'json', accept: '*/*', context })
    ).pipe(
      map((event: HttpEvent<Gender[]>) => {
        if (event instanceof HttpResponse) {
          return {
            headers: event.headers,
            status: event.status,
            statusText: event.statusText,
            url: event.url ? event.url : null,
            body: event.body ? event.body : []
          };
        }
        return null;
      }),
      filter((response: any): response is StrictHttpResponse<Gender[]> => response !== null)
    );
  }

  /**
   * This method provides access only to the response body.
   * To access the full response (for headers, for example), `gendersPost$Response()` instead.
   *
   * This method doesn't expect any request body.
   */
  gendersPost(
    params?: {
    },
    context?: HttpContext
  ): Observable<Gender[]> {
    return this.gendersPost$Response(params, context).pipe(
      map((r: StrictHttpResponse<Gender[]>): Gender[] => r.body)
    );
  }

  /** Path part for operation `categoriesPost()` */
  static readonly CategoriesPostPath = '/categories';

  /**
   * This method provides access to the full `HttpResponse`, allowing access to response headers.
   * To access only the response body, use `categoriesPost()` instead.
   *
   * This method doesn't expect any request body.
   */
  categoriesPost$Response(
    params?: {
    },
    context?: HttpContext
  ): Observable<StrictHttpResponse<Category[]>> {
    const rb = new RequestBuilder(this.rootUrl, MainService.CategoriesPostPath, 'post');
    if (params) {
    }

    return this.http.request<Category[]>(
      rb.build({ responseType: 'json', accept: '*/*', context })
    ).pipe(
      map((event: HttpEvent<Category[]>) => {
        if (event instanceof HttpResponse) {
          return {
            headers: event.headers,
            status: event.status,
            statusText: event.statusText,
            url: event.url ? event.url : null,
            body: event.body ? event.body : []
          };
        }
        return null;
      }),
      filter((response: any): response is StrictHttpResponse<Category[]> => response !== null)
    );
  }

  /**
   * This method provides access only to the response body.
   * To access the full response (for headers, for example), `categoriesPost$Response()` instead.
   *
   * This method doesn't expect any request body.
   */
  categoriesPost(
    params?: {
    },
    context?: HttpContext
  ): Observable<Category[]> {
    return this.categoriesPost$Response(params, context).pipe(
      map((r: StrictHttpResponse<Category[]>): Category[] => r.body)
    );
  }

  /** Path part for operation `currenciesPost()` */
  static readonly CurrenciesPostPath = '/currencies';

  /**
   * This method provides access to the full `HttpResponse`, allowing access to response headers.
   * To access only the response body, use `currenciesPost()` instead.
   *
   * This method doesn't expect any request body.
   */
  currenciesPost$Response(
    params?: {
    },
    context?: HttpContext
  ): Observable<StrictHttpResponse<Currency[]>> {
    const rb = new RequestBuilder(this.rootUrl, MainService.CurrenciesPostPath, 'post');
    if (params) {
    }

    return this.http.request<Currency[]>(
      rb.build({ responseType: 'json', accept: '*/*', context })
    ).pipe(
      map((event: HttpEvent<Currency[]>) => {
        if (event instanceof HttpResponse) {
          return {
            headers: event.headers,
            status: event.status,
            statusText: event.statusText,
            url: event.url ? event.url : null,
            body: event.body ? event.body : []
          };
        }
        return null;
      }),
      filter((response: any): response is StrictHttpResponse<Currency[]> => response !== null)
    );
  }

  /**
   * This method provides access only to the response body.
   * To access the full response (for headers, for example), `currenciesPost$Response()` instead.
   *
   * This method doesn't expect any request body.
   */
  currenciesPost(
    params?: {
    },
    context?: HttpContext
  ): Observable<Currency[]> {
    return this.currenciesPost$Response(params, context).pipe(
      map((r: StrictHttpResponse<Currency[]>): Currency[] => r.body)
    );
  }

}
