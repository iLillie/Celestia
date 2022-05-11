<template>
  <section>
    <header>
      <h2>{{ advertStatus.title }}</h2>
      <p>{{ advertStatus.adverts.length }}</p>
      <IconButton icon="ri-more-fill"/>
    </header>
    <div class="flex flex-col h-full p-8 overflow-y-auto">
      <AdvertItem v-for="advert in advertStatus.adverts" :key="advert.id"/>
    </div>
  </section>
</template>

<script>
export default {
  name: "AdvertStatus",
  props: {
    advertStatus: Object
  }
}
</script>

<style scoped>

</style>
