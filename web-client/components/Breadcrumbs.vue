<template>
  <ol class="list-none p-0 flex gap-4">
    <li v-for="item in items">
      {{item}}
    </li>
  </ol>
</template>

<script>
export default {
  name: "Breadcrumbs",
  data() {
    return {
      items: [
        "Stillinger", "/" , "S-01"
      ]
    }
  }
}
</script>

<style scoped>

</style>
