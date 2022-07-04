import { RayTracingAppPage } from './app.po';

describe('ray-tracing-app App', function() {
  let page: RayTracingAppPage;

  beforeEach(() => {
    page = new RayTracingAppPage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
